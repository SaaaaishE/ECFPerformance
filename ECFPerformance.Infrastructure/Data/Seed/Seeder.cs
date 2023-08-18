using ECFPerformance.Infrastructure.Data.Models;
using ECFPerformance.Infrastructure.Data.Models.Engine;
using ECFPerformance.Infrastructure.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using static ECFPerformance.Constants.GeneralApplicationConstants;
using ECFPerformance.Infrastructure.Data.Models.Projects;

namespace ECFPerformance.Infrastructure.Data.Seed
{
    public static class Seeder
    {
        private static ApplicationUser[] admin;
        private static EngineType[] engineTypes;
        private static TurboScrollType[] turboScrollTypes;
        private static ConnectingRodBeamType[] connectingRodBeamTypes;
        private static Category[] categories;
        private static Turbo[] turbos;
        private static ConnectingRod[] connectingRods;
        private static ConnectingRodEngineType[] connectingRodEngineTypes;
        private static ProjectCar[] projectCars;

        public static ApplicationUser[] SeedAdmin()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            admin = new ApplicationUser[1];
            admin[0] = new ApplicationUser()
            {
                FirstName = "Alex",
                LastName = "Gavrilov",
                PhoneNumber = "+3594567891",
                Email = DevelopmentAdminEmail,
                NormalizedEmail = DevelopmentAdminEmail,
                UserName = DevelopmentAdminEmail,
                NormalizedUserName = DevelopmentAdminEmail,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            admin[0].PasswordHash = hasher.HashPassword(admin[0], "123456");
            
            return admin;
        }

        public static EngineType[] SeedEngineTypes()
        {
            engineTypes = new EngineType[6];

            engineTypes[0] = new EngineType()
            {
                EngineCode = EngineEnum.M52B28,
                Id = 1
            };
            engineTypes[1] = new EngineType()
            {
                EngineCode = EngineEnum.M54B30,
                Id = 2
            };
            engineTypes[2] = new EngineType()
            {
                EngineCode = EngineEnum.D16,
                Id = 3
            };
            engineTypes[3] = new EngineType()
            {
                EngineCode = EngineEnum.D15,
                Id = 4
            };
            engineTypes[4] = new EngineType()
            {
                EngineCode = EngineEnum.BP6,
                Id = 5
            };
            engineTypes[5] = new EngineType()
            {
                EngineCode = EngineEnum.BP8,
                Id = 6
            };

            return engineTypes;
        }

        public static TurboScrollType[] SeedTurboScrollTypes()
        {
            turboScrollTypes = new TurboScrollType[2];

            turboScrollTypes[0] = new TurboScrollType()
            {
                ScrollType = ScrollType.SingleScroll,
                Id = 1
            };
            turboScrollTypes[1] = new TurboScrollType()
            {
                ScrollType = ScrollType.TwinScroll,
                Id = 2
            };

            return turboScrollTypes;
        }

        public static ConnectingRodBeamType[] SeedBeamTypes()
        {
            connectingRodBeamTypes = new ConnectingRodBeamType[2];

            connectingRodBeamTypes[0] = new ConnectingRodBeamType()
            {
                Id = 1,
                ConnectingRodBeam = ConnectingRodBeamEnum.I
            };
            connectingRodBeamTypes[1] = new ConnectingRodBeamType()
            {
                Id = 2,
                ConnectingRodBeam = ConnectingRodBeamEnum.H
            };

            return connectingRodBeamTypes;
        }

        public static Category[] SeedCategories()
        {
            categories = new Category[4];

            categories[0] = new Category()
            {
                CategoryName = "Engine",
                Id = 1,
            };
            categories[1] = new Category()
            {
                CategoryName = "Chassis",
                Id = 2,
            };
            categories[2] = new Category()
            {
                CategoryName = "Suspension",
                Id = 3,
            };
            categories[3] = new Category()
            {
                CategoryName = "Exhaust",
                Id = 4,
            };

            return categories;
        }

        public static Turbo[] SeedTurbos()
        {
            turbos = new Turbo[4];

            turbos[0] = new Turbo()
            {
                Id = 1,
                CategoryId = 1,
                Make = "MaxPeedingRods",
                Name = "GT30",
                Quantity = 3,
                Price = 130.00m,
                ScrollTypeId = 1,
                MainImage = "https://m.media-amazon.com/images/I/612l0wYluUL._AC_SX522_.jpg"
            };
            turbos[1] = new Turbo()
            {
                Id = 2,
                CategoryId = 1,
                Make = "MaxPeedingRods",
                Name = "GT35",
                Quantity = 3,
                Price = 230.00m,
                ScrollTypeId = 1,
                MainImage = "https://s19529.pcdn.co/wp-content/uploads/2021/02/Screen-Shot-2021-02-22-at-10.05.38-AM.png"
            };
            turbos[2] = new Turbo()
            {
                Id = 3,
                CategoryId = 1,
                Make = "Holset",
                Name = "HX40",
                Quantity = 3,
                Price = 500.00m,
                ScrollTypeId = 2,
                MainImage = "https://th.bing.com/th/id/OIP.z3vjnJxtodUyIYBQigac8gHaGw?pid=ImgDet&rs=1"
            };
            turbos[3] = new Turbo()
            {
                Id = 4,
                CategoryId = 1,
                Make = "Holset",
                Name = "HX35",
                Quantity = 3,
                Price = 450.00m,
                ScrollTypeId = 2,
                MainImage = "https://th.bing.com/th/id/R.145fdefb10871f3b499c8e9bbc1ff9c8?rik=w4kn89cj4XnJlw&pid=ImgRaw&r=0"
            };

            return turbos;
        }

        public static ConnectingRod[] SeedConnectingRods()
        {
            connectingRods = new ConnectingRod[6];

            connectingRods[0] = new ConnectingRod()
            {
                Id = 1,
                CategoryId = 1,
                BeamTypeId = 1,
                Name = "BMW Beam Type I Connecting Rod 135mm",
                Make = "Eagle",
                Quantity = 3,
                Length = 135,
                MainImage = "https://www.eaglerod.com/images/1c475ca0-bfd5-11ea-b02a-c48ef5f8d3b6/jpg/5313-4340-h-beam-bmw-38-arp-2000-bolts/crs-5313b63d-1.jpg",
                Price = 670m,
                PistonBoltDiameter = 22
            };
            connectingRods[1] = new ConnectingRod()
            {
                Id = 2,
                CategoryId = 1,
                BeamTypeId = 2,
                Name = "BMW Beam Type H Connecting Rod 135mm",
                Make = "MaxPeedingRods",
                Quantity = 3,
                Length = 135,
                MainImage = "https://webp.cqggedm.com/image/brand-max/gallery/en-gb/rod/forged-rods-cr-6/default/main/forged-rods-cr-6(1).jpg?x-oss-process=image/auto-orient,1/quality,q_70/resize,m_mfit,w_1000,h_1000/format,webp",
                Price = 580m,
                PistonBoltDiameter = 22
            };
            connectingRods[2] = new ConnectingRod()
            {
                Id = 3,
                CategoryId = 1,
                BeamTypeId = 2,
                Name = "Mazda H Beam ",
                Make = "MaxPeedingRods",
                Quantity = 3,
                Length = 133,
                MainImage = "https://webp.cqggedm.com/image/brand-max/gallery/en-gb/rod/forged-rods-cr-4/default/main/forged-rods-cr-4(1).jpg?x-oss-process=image/auto-orient,1/quality,q_70/resize,m_mfit,w_1000,h_1000",
                Price = 357m,
                PistonBoltDiameter = 20
            };
            connectingRods[3] = new ConnectingRod()
            {
                Id = 4,
                CategoryId = 1,
                BeamTypeId = 1,
                Name = "Mazda I Beam",
                Make = "Eagle",
                Quantity = 3,
                Length = 133,
                MainImage = "https://cdn.yellowhatweb.com/file/storage-yellowhatweb-com/84c3ce8a-bfd5-11ea-87b6-e6954ea1f6b1.jpg",
                Price = 460m,
                PistonBoltDiameter = 20
            };
            connectingRods[4] = new ConnectingRod()
            {
                Id = 5,
                CategoryId = 1,
                BeamTypeId = 2,
                Name = "Honda H Beam",
                Make = "MaxPeedingRods",
                Quantity = 3,
                Length = 137,
                MainImage = "https://webp.cqggedm.com/image/brand-max/gallery/en-gb/rod/forged-rods-cr-4/default/main/forged-rods-cr-4(1).jpg?x-oss-process=image/auto-orient,1/quality,q_70/resize,m_mfit,w_1000,h_1000/format,webp",
                Price = 359m,
                PistonBoltDiameter = 19
            };
            connectingRods[5] = new ConnectingRod()
            {
                Id = 6,
                CategoryId = 1,
                BeamTypeId = 1,
                Name = "Honda I Beam",
                Make = "Eagle",
                Quantity = 3,
                Length = 137,
                MainImage = "https://cdn.yellowhatweb.com/file/storage-yellowhatweb-com/870fa77e-bfd3-11ea-b02b-15c463fe2bce.jpg",
                Price = 465m,
                PistonBoltDiameter = 19
            };

            return connectingRods;
        }

        public static ConnectingRodEngineType[] SeedRodsEngines()
        {
            connectingRodEngineTypes = new ConnectingRodEngineType[12];

            //bmw rods
            connectingRodEngineTypes[0] = new ConnectingRodEngineType()
            {
                CompatibleEngineId = 1,
                CompatibleRodId = 1,
            };
            connectingRodEngineTypes[1] = new ConnectingRodEngineType()
            {
                CompatibleEngineId = 1,
                CompatibleRodId = 2,
            };
            connectingRodEngineTypes[2] = new ConnectingRodEngineType()
            {
                CompatibleEngineId = 2,
                CompatibleRodId = 1,
            };
            connectingRodEngineTypes[3] = new ConnectingRodEngineType()
            {
                CompatibleEngineId = 2,
                CompatibleRodId = 2,
            };

            //mazda rods
            connectingRodEngineTypes[4] = new ConnectingRodEngineType()
            {
                CompatibleEngineId = 5,
                CompatibleRodId = 3,
            };
            connectingRodEngineTypes[5] = new ConnectingRodEngineType()
            {
                CompatibleEngineId = 5,
                CompatibleRodId = 4,
            };
            connectingRodEngineTypes[6] = new ConnectingRodEngineType()
            {
                CompatibleEngineId = 6,
                CompatibleRodId = 3,
            };
            connectingRodEngineTypes[7] = new ConnectingRodEngineType()
            {
                CompatibleEngineId = 6,
                CompatibleRodId = 4,
            };

            //honda rods
            connectingRodEngineTypes[8] = new ConnectingRodEngineType()
            {
                CompatibleEngineId = 3,
                CompatibleRodId = 5,
            };
            connectingRodEngineTypes[9] = new ConnectingRodEngineType()
            {
                CompatibleEngineId = 3,
                CompatibleRodId = 6,
            };
            connectingRodEngineTypes[10] = new ConnectingRodEngineType()
            {
                CompatibleEngineId = 4,
                CompatibleRodId = 5,
            };
            connectingRodEngineTypes[11] = new ConnectingRodEngineType()
            {
                CompatibleEngineId = 4,
                CompatibleRodId = 6,
            };

            return connectingRodEngineTypes;
        }

        public static ProjectCar[] SeedProjectCars()
        {
            projectCars = new ProjectCar[1];

            string valkataDescr = "Engine: \n" +
                                  " - M50B28 stroker \n" +
                                  " - ConnectingRods - Forged MaxPeedingRods \n" +
                                  " - Pistons - From M40B18 Engine \n" +
                                  " - Turbo - GT35 \n" +
                                  " - HorsePower - ~ 400 \n" +
                                  "Chassis: \n" +
                                  " - E36 Coupe \n" +
                                  " - Angle Kit - WiseFab Replica";

            projectCars[0] = new ProjectCar()
            {
                Id = 1,
                Description = valkataDescr,
                MainImage = "/imgs/valkata.jpg",
                Name = "E36 Coupe M50B28 Turbo",
            };

            return projectCars;
        }
    }
}
