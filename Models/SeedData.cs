//using ProjectSuperhero.Data;
//using Microsoft.Build.Tasks;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Linq;

//namespace ProjectSuperhero.Models;

//public static class SeedData
//{
//    public static void Initialize(IServiceProvider serviceProvider)
//    {
//        using (var context = new ProjectSuperheroContext(
//            serviceProvider.GetRequiredService<
//                DbContextOptions<ProjectSuperheroContext>>()))
//        {
//            // Look for any movies.
//            if (context.Patient.Any())
//            {
//                return;   // DB has been seeded
//            }
//            context.Patient.AddRange(
//                new Patient
//                {
//                    OIB = "10293847561",
//                    MBO = "112233445",
//                    FullName = "John Smith",
//                    DateOfBirth = DateTime.Parse("1975-03-12"),
//                    Gender = "Male",
//                    Diagnosis = "A01",
//                    AdmissionDate = DateTime.Parse("2020-04-09"),
//                    DismissalDate = DateTime.Parse("1970-01-01"),
//                    IsDismissed = false
//                },
//                new Patient
//                {
//                    OIB = "99887766552",
//                    MBO = "147147142",
//                    FullName = "William Wright",
//                    DateOfBirth = DateTime.Parse("1966-11-10"),
//                    Gender = "Male",
//                    Diagnosis = "T98",
//                    AdmissionDate = DateTime.Parse("2026-04-08"),
//                    DismissalDate = DateTime.Parse("1970-01-01"),
//                    IsDismissed = true
//                },
//                new Patient
//                {
//                    OIB = "92837465012",
//                    MBO = "998877665",
//                    FullName = "Ada Lovelace-Error",
//                    DateOfBirth = DateTime.Parse("1985-12-10"),
//                    Gender = "Female",
//                    Diagnosis = "B42",
//                    AdmissionDate = DateTime.Parse("2018-05-20"),
//                    DismissalDate = DateTime.Parse("2018-06-01"),
//                    IsDismissed = true
//                },
//                new Patient
//                {
//                    OIB = "19283746501",
//                    MBO = "123450987",
//                    FullName = "Linus Segfault",
//                    DateOfBirth = DateTime.Parse("1991-08-25"),
//                    Gender = "Male",
//                    Diagnosis = "K07",
//                    AdmissionDate = DateTime.Parse("2022-11-14"),
//                    DismissalDate = DateTime.Parse("1970-01-01"),
//                    IsDismissed = false
//                },
//                new Patient
//                {
//                    OIB = "55667788990",
//                    MBO = "445566778",
//                    FullName = "Bella C. Out",
//                    DateOfBirth = DateTime.Parse("2000-01-01"),
//                    Gender = "Female",
//                    Diagnosis = "Z99",
//                    AdmissionDate = DateTime.Parse("2021-03-15"),
//                    DismissalDate = DateTime.Parse("2021-03-20"),
//                    IsDismissed = true
//                },
//                new Patient
//                {
//                    OIB = "10293847562",
//                    MBO = "887766554",
//                    FullName = "John D. Hacker",
//                    DateOfBirth = DateTime.Parse("1980-04-04"),
//                    Gender = "Male",
//                    Diagnosis = "X12",
//                    AdmissionDate = DateTime.Parse("2019-09-12"),
//                    DismissalDate = DateTime.Parse("2019-09-25"),
//                    IsDismissed = true
//                },
//                new Patient
//                {
//                    OIB = "88229933110",
//                    MBO = "112233446",
//                    FullName = "Ruby Rails",
//                    DateOfBirth = DateTime.Parse("1995-10-15"),
//                    Gender = "Female",
//                    Diagnosis = "R05",
//                    AdmissionDate = DateTime.Parse("2024-01-10"),
//                    DismissalDate = DateTime.Parse("1970-01-01"),
//                    IsDismissed = false
//                },
//                new Patient
//                {
//                    OIB = "77336644221",
//                    MBO = "556644332",
//                    FullName = "Jason Object",
//                    DateOfBirth = DateTime.Parse("1988-07-22"),
//                    Gender = "Male",
//                    Diagnosis = "J01",
//                    AdmissionDate = DateTime.Parse("2020-02-28"),
//                    DismissalDate = DateTime.Parse("2020-03-05"),
//                    IsDismissed = true
//                },
//                new Patient
//                {
//                    OIB = "44118822553",
//                    MBO = "990011223",
//                    FullName = "Sally S. Q. Elle",
//                    DateOfBirth = DateTime.Parse("1992-05-18"),
//                    Gender = "Female",
//                    Diagnosis = "D20",
//                    AdmissionDate = DateTime.Parse("2023-06-15"),
//                    DismissalDate = DateTime.Parse("1970-01-01"),
//                    IsDismissed = false
//                },
//                new Patient
//                {
//                    OIB = "33991177448",
//                    MBO = "667788990",
//                    FullName = "Chip Silicon",
//                    DateOfBirth = DateTime.Parse("1972-11-30"),
//                    Gender = "Male",
//                    Diagnosis = "H10",
//                    AdmissionDate = DateTime.Parse("2017-12-01"),
//                    DismissalDate = DateTime.Parse("2017-12-15"),
//                    IsDismissed = true
//                },
//                new Patient
//                {
//                    OIB = "11559933772",
//                    MBO = "223344556",
//                    FullName = "Grace Hopper-Overflow",
//                    DateOfBirth = DateTime.Parse("1982-02-02"),
//                    Gender = "Female",
//                    Diagnosis = "G09",
//                    AdmissionDate = DateTime.Parse("2022-08-20"),
//                    DismissalDate = DateTime.Parse("2022-08-30"),
//                    IsDismissed = true
//                },
//                new Patient
//                {
//                    OIB = "66004488225",
//                    MBO = "778899001",
//                    FullName = "Artie Ficial",
//                    DateOfBirth = DateTime.Parse("1999-09-09"),
//                    Gender = "Male",
//                    Diagnosis = "A55",
//                    AdmissionDate = DateTime.Parse("2025-02-14"),
//                    DismissalDate = DateTime.Parse("1970-01-01"),
//                    IsDismissed = false
//                },
//                new Patient
//                {
//                    OIB = "22883377114",
//                    MBO = "334455667",
//                    FullName = "Cookie Crumbs",
//                    DateOfBirth = DateTime.Parse("2005-06-06"),
//                    Gender = "Female",
//                    Diagnosis = "C19",
//                    AdmissionDate = DateTime.Parse("2024-11-20"),
//                    DismissalDate = DateTime.Parse("2024-11-25"),
//                    IsDismissed = true
//                },
//                new Patient
//                {
//                    OIB = "12123434565",
//                    MBO = "101020203",
//                    FullName = "Otto Maton",
//                    DateOfBirth = DateTime.Parse("1980-08-08"),
//                    Gender = "Male",
//                    Diagnosis = "M08",
//                    AdmissionDate = DateTime.Parse("2021-07-07"),
//                    DismissalDate = DateTime.Parse("1970-01-01"),
//                    IsDismissed = false
//                },
//                new Patient
//                {
//                    OIB = "56567878909",
//                    MBO = "404050506",
//                    FullName = "Anna Log",
//                    DateOfBirth = DateTime.Parse("1994-03-21"),
//                    Gender = "Female",
//                    Diagnosis = "L11",
//                    AdmissionDate = DateTime.Parse("2019-04-10"),
//                    DismissalDate = DateTime.Parse("2019-04-12"),
//                    IsDismissed = true
//                },
//                new Patient
//                {
//                    OIB = "90901212343",
//                    MBO = "707080809",
//                    FullName = "Benny Binary",
//                    DateOfBirth = DateTime.Parse("2001-12-25"),
//                    Gender = "Male",
//                    Diagnosis = "B02",
//                    AdmissionDate = DateTime.Parse("2023-10-31"),
//                    DismissalDate = DateTime.Parse("1970-01-01"),
//                    IsDismissed = false
//                },
//                new Patient
//                {
//                    OIB = "34345656787",
//                    MBO = "111222333",
//                    FullName = "Tera Byte",
//                    DateOfBirth = DateTime.Parse("1987-01-15"),
//                    Gender = "Female",
//                    Diagnosis = "T64",
//                    AdmissionDate = DateTime.Parse("2018-01-15"),
//                    DismissalDate = DateTime.Parse("2018-02-01"),
//                    IsDismissed = true
//                },
//                new Patient
//                {
//                    OIB = "78789090121",
//                    MBO = "444555666",
//                    FullName = "Al Gorythm",
//                    DateOfBirth = DateTime.Parse("1979-11-11"),
//                    Gender = "Male",
//                    Diagnosis = "G13",
//                    AdmissionDate = DateTime.Parse("2020-05-05"),
//                    DismissalDate = DateTime.Parse("1970-01-01"),
//                    IsDismissed = false
//                },
//                new Patient
//                {
//                    OIB = "00011122233",
//                    MBO = "777888999",
//                    FullName = "Cee Sharp",
//                    DateOfBirth = DateTime.Parse("2002-02-22"),
//                    Gender = "Female",
//                    Diagnosis = "S01",
//                    AdmissionDate = DateTime.Parse("2024-03-01"),
//                    DismissalDate = DateTime.Parse("2024-03-10"),
//                    IsDismissed = true
//                },
//                new Patient
//                {
//                    OIB = "44455566677",
//                    MBO = "000111222",
//                    FullName = "Phil File",
//                    DateOfBirth = DateTime.Parse("1996-05-04"),
//                    Gender = "Male",
//                    Diagnosis = "F04",
//                    AdmissionDate = DateTime.Parse("2025-01-01"),
//                    DismissalDate = DateTime.Parse("1970-01-01"),
//                    IsDismissed = false
//                },
//                new Patient
//                {
//                    OIB = "88899900011",
//                    MBO = "333444555",
//                    FullName = "Molly Macro",
//                    DateOfBirth = DateTime.Parse("1990-09-09"),
//                    Gender = "Female",
//                    Diagnosis = "M40",
//                    AdmissionDate = DateTime.Parse("2022-12-25"),
//                    DismissalDate = DateTime.Parse("2022-12-27"),
//                    IsDismissed = true
//                },
//                new Patient
//                {
//                    OIB = "22233344455",
//                    MBO = "666777888",
//                    FullName = "Eddy Editor",
//                    DateOfBirth = DateTime.Parse("1983-06-30"),
//                    Gender = "Male",
//                    Diagnosis = "E11",
//                    AdmissionDate = DateTime.Parse("2021-08-15"),
//                    DismissalDate = DateTime.Parse("1970-01-01"),
//                    IsDismissed = false
//                }
//            );
//            context.SaveChanges();
//        }
//    }
//}