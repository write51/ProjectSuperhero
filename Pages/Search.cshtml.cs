using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectSuperhero.Models;

namespace ProjectSuperhero.Pages
{
    public class SearchModel : PageModel
    {
        private readonly ProjectSuperhero.Data.ProjectSuperheroContext _context;

        public SearchModel(ProjectSuperhero.Data.ProjectSuperheroContext context)
        {
            _context = context;
        }

        public IList<Comic> Comic { get; set; } = default!;

        // --- Pagination Properties ---
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPages;
        public int PageSize { get; set; } = 32; // Limit to maximum 32 items

        public class ComicQuery
        {
            public string SortOrder { get; set; }
            public string Id { get; set; }
            public string SeriesId { get; set; }
            public string Name { get; set; }
            public string OtherName { get; set; }
            public string Number { get; set; }
            public string Genres { get; set; }
            public string Publisher { get; set; }
            public string Writer { get; set; }
            public string Artist { get; set; }
            public string Rating { get; set; }
            public string ReleaseDate { get; set; }
            public string PublicationDate { get; set; }
            public string Cover { get; set; }
            public string Resource { get; set; }
            public string Summary { get; set; }
            public int? PageIndex { get; set; } // Tracks page from URL
        }

        public async Task OnGetAsync(ComicQuery query)
        {
            CurrentPage = query.PageIndex ?? 1;
            if (CurrentPage < 1) CurrentPage = 1;

            // Setup Sort Parameters for the UI Table Headers
            ViewData["CurrentSort"] = query.SortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(query.SortOrder) ? "name_desc" : "";
            ViewData["NumberSortParm"] = query.SortOrder == "number_asc" ? "number_desc" : "number_asc";
            ViewData["ReleaseDateSortParm"] = query.SortOrder == "releasedate_asc" ? "releasedate_desc" : "releasedate_asc";
            ViewData["RatingSortParm"] = query.SortOrder == "rating_asc" ? "rating_desc" : "rating_asc";
            ViewData["PublisherSortParm"] = query.SortOrder == "publisher_asc" ? "publisher_desc" : "publisher_asc";

            // Store Filters so the input boxes stay populated after hitting submit
            ViewData["IdFilter"] = query.Id;
            ViewData["SeriesIdFilter"] = query.SeriesId;
            ViewData["NameFilter"] = query.Name;
            ViewData["OtherNameFilter"] = query.OtherName;
            ViewData["NumberFilter"] = query.Number;
            ViewData["GenresFilter"] = query.Genres;
            ViewData["PublisherFilter"] = query.Publisher;
            ViewData["WriterFilter"] = query.Writer;
            ViewData["ArtistFilter"] = query.Artist;
            ViewData["RatingFilter"] = query.Rating;
            ViewData["ReleaseDateFilter"] = query.ReleaseDate;
            ViewData["PublicationDateFilter"] = query.PublicationDate;
            ViewData["CoverFilter"] = query.Cover;
            ViewData["ResourceFilter"] = query.Resource;
            ViewData["SummaryFilter"] = query.Summary;

            // Start with the base query
            var comicsQuery = _context.Comic.AsQueryable();

            // ==========================================
            // 1. FILTERING LOGIC
            // ==========================================
            if (!string.IsNullOrEmpty(query.Id) && long.TryParse(query.Id, out long idVal))
            {
                comicsQuery = comicsQuery.Where(s => s.Id == idVal);
            }
            if (!string.IsNullOrEmpty(query.SeriesId) && long.TryParse(query.SeriesId, out long seriesIdVal))
            {
                comicsQuery = comicsQuery.Where(s => s.SeriesId == seriesIdVal);
            }
            if (!string.IsNullOrEmpty(query.Number) && long.TryParse(query.Number, out long numberVal))
            {
                comicsQuery = comicsQuery.Where(s => s.Number == numberVal);
            }
            if (!string.IsNullOrEmpty(query.Name))
            {
                comicsQuery = comicsQuery.Where(s => s.Name.Contains(query.Name));
            }
            if (!string.IsNullOrEmpty(query.OtherName))
            {
                comicsQuery = comicsQuery.Where(s => s.OtherName != null && s.OtherName.Contains(query.OtherName));
            }
            if (!string.IsNullOrEmpty(query.Genres))
            {
                comicsQuery = comicsQuery.Where(s => s.Genres != null && s.Genres.Contains(query.Genres));
            }
            if (!string.IsNullOrEmpty(query.Publisher))
            {
                comicsQuery = comicsQuery.Where(s => s.Publisher != null && s.Publisher.Contains(query.Publisher));
            }
            if (!string.IsNullOrEmpty(query.Writer))
            {
                comicsQuery = comicsQuery.Where(s => s.Writer != null && s.Writer.Contains(query.Writer));
            }
            if (!string.IsNullOrEmpty(query.Artist))
            {
                comicsQuery = comicsQuery.Where(s => s.Artist != null && s.Artist.Contains(query.Artist));
            }
            if (!string.IsNullOrEmpty(query.PublicationDate))
            {
                comicsQuery = comicsQuery.Where(s => s.PublicationDate != null && s.PublicationDate.Contains(query.PublicationDate));
            }
            if (!string.IsNullOrEmpty(query.Cover))
            {
                comicsQuery = comicsQuery.Where(s => s.Cover != null && s.Cover.Contains(query.Cover));
            }
            if (!string.IsNullOrEmpty(query.Resource))
            {
                comicsQuery = comicsQuery.Where(s => s.Resource != null && s.Resource.Contains(query.Resource));
            }
            if (!string.IsNullOrEmpty(query.Summary))
            {
                comicsQuery = comicsQuery.Where(s => s.Summary != null && s.Summary.Contains(query.Summary));
            }
            if (!string.IsNullOrEmpty(query.Rating) && long.TryParse(query.Rating, out long ratingVal))
            {
                comicsQuery = comicsQuery.Where(s => s.Rating >= ratingVal);
            }
            if (!string.IsNullOrEmpty(query.ReleaseDate) && DateTime.TryParse(query.ReleaseDate, out DateTime rDate))
            {
                comicsQuery = comicsQuery.Where(s => s.ReleaseDate.Date == rDate.Date);
            }

            // ==========================================
            // 2. SORTING LOGIC
            // ==========================================
            comicsQuery = query.SortOrder switch
            {
                "name_desc" => comicsQuery.OrderByDescending(s => s.Name),
                "number_asc" => comicsQuery.OrderBy(s => s.Number),
                "number_desc" => comicsQuery.OrderByDescending(s => s.Number),
                "releasedate_asc" => comicsQuery.OrderBy(s => s.ReleaseDate),
                "releasedate_desc" => comicsQuery.OrderByDescending(s => s.ReleaseDate),
                "rating_asc" => comicsQuery.OrderBy(s => s.Rating),
                "rating_desc" => comicsQuery.OrderByDescending(s => s.Rating),
                "publisher_asc" => comicsQuery.OrderBy(s => s.Publisher),
                "publisher_desc" => comicsQuery.OrderByDescending(s => s.Publisher),
                _ => comicsQuery.OrderBy(s => s.Name),
            };

            // ==========================================
            // 3. PAGINATION EXECUTION
            // ==========================================
            int count = await comicsQuery.CountAsync();
            TotalPages = (int)Math.Ceiling(count / (double)PageSize);

            Comic = await comicsQuery
                .Skip((CurrentPage - 1) * PageSize)
                .Take(PageSize)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}