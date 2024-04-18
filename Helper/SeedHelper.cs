using FribergHomez.Data;
using FribergHomez.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace FribergHomez.Helper
{
    public class SeedHelper
    {
        /*
                public async Task SeedCategoriesAsync(ApplicationDbContext applicationDbContext)
                    //All
                {
                    if (!context.Realtors.Any())
                    {
                        var firm1 = new Firm("Homewise Solutions", "HomePerfected", "PerfectHomeImages");
                        var firm2 = new Firm("Urban Nest Realty", "CityScape Living", "UrbanNestImages");
                        var firm3 = new Firm("EquiHome Realtors", "BalancedDwellings", "EquiHomeGallery");

                        var agent1 = new RealEstateAgent("John", "Doe", "john@example.com", firm1, "1234567890", "image_url_here");
                        var agent2 = new RealEstateAgent("Emily", "Smith", "emily@example.com", firm2, "2345678901", "image_url_here");
                        var agent3 = new RealEstateAgent("Michael", "Johnson", "michael@example.com", firm3, "3456789012", "image_url_here");
                        var agent4 = new RealEstateAgent("Jessica", "Brown", "jessica@example.com", firm1, "4567890123", "image_url_here");
                        var agent5 = new RealEstateAgent("David", "Martinez", "david@example.com", firm2, "5678901234", "image_url_here");
                        var agent6 = new RealEstateAgent("Jennifer", "Garcia", "jennifer@example.com", firm3, "6789012345", "image_url_here");
                        var agent7 = new RealEstateAgent("Christopher", "Wilson", "chris@example.com", firm1, "7890123456", "image_url_here");
                        var agent8 = new RealEstateAgent("Ashley", "Anderson", "ashley@example.com", firm2, "8901234567", "image_url_here");
                        var agent9 = new RealEstateAgent("Matthew", "Taylor", "matthew@example.com", firm3, "9012345678", "image_url_here");
                        var agent10 = new RealEstateAgent("Jessica", "Thomas", "jessica@example.com", firm1, "0123456789", "image_url_here");


                        var municipality1 = new Municipality("Ale");
                        var municipality2 = new Municipality("Alingsås");
                        var municipality3 = new Municipality("Alvesta");
                        var municipality4 = new Municipality("Aneby");
                        var municipality5 = new Municipality("Arboga");
                        var municipality6 = new Municipality("Arjeplog");
                        var municipality7 = new Municipality("Arvidsjaur");
                        var municipality8 = new Municipality("Arvika");
                        var municipality9 = new Municipality("Askersund");
                        var municipality10 = new Municipality("Avesta");

                        var category1 = new Category("House");
                        var category2 = new Category("Cottage");
                        var category3 = new Category("Condo");
                        var category4 = new Category("Condo Terraced House"); 

                        var saleObject1 = new SaleObject
                        {
                            Address = "Storgatan 555",
                            Municipality = municipality1,
                            Category = category1,
                            StartingPrice = 250000,
                            LivingArea = 200,
                            AncillaryArea = 50,
                            PlotArea = 500,
                            Description = "Beautiful house with garden",
                            NumberOfRooms = 5,
                            MonthlyFee = 100,
                            OperatingCostPerYear = 2000,
                            YearOfConstruction = 2000,
                            ImageUrl = new List<string> { "image_url1", "image_url2" },
                            RealEstateAgent = agent1
                        };
                        var saleObject2 = new SaleObject
                        {
                            Address = "Stenvägen 4",
                            Municipality = municipality2,
                            Category = category2,
                            StartingPrice = 250000,
                            LivingArea = 200,
                            AncillaryArea = 50,
                            PlotArea = 500,
                            Description = "Beautiful cottage with garden",
                            NumberOfRooms = 5,
                            MonthlyFee = 100,
                            OperatingCostPerYear = 2000,
                            YearOfConstruction = 2000,
                            ImageUrl = new List<string> { "image_url1", "image_url2" },
                            RealEstateAgent = agent2
                        };
                        var saleObject3 = new SaleObject
                        {
                            Address = "Grusvägen 123",
                            Municipality = municipality3,
                            Category = category3,
                            StartingPrice = 250000,
                            LivingArea = 200,
                            AncillaryArea = 50,
                            PlotArea = 500,
                            Description = "Beautiful Condo with garden",
                            NumberOfRooms = 5,
                            MonthlyFee = 100,
                            OperatingCostPerYear = 2000,
                            YearOfConstruction = 2000,
                            ImageUrl = new List<string> { "image_url1", "image_url2" },
                            RealEstateAgent = agent3
                        };
                        var saleObject4 = new SaleObject
                        {
                            Address = "Mittivägen 55",
                            Municipality = municipality4,
                            Category = category4,
                            StartingPrice = 250000,
                            LivingArea = 200,
                            AncillaryArea = 50,
                            PlotArea = 500,
                            Description = "This is definitely a place where you can live",
                            NumberOfRooms = 5,
                            MonthlyFee = 100,
                            OperatingCostPerYear = 2000,
                            YearOfConstruction = 2000,
                            ImageUrl = new List<string> { "image_url1", "image_url2" },
                            RealEstateAgent = agent4
                        };
                        var saleObject5 = new SaleObject
                        {
                            Address = "NågonstansISverige 66",
                            Municipality = municipality6,
                            Category = category1,
                            StartingPrice = 250000,
                            LivingArea = 200,
                            AncillaryArea = 50,
                            PlotArea = 500,
                            Description = "This is a house",
                            NumberOfRooms = 5,
                            MonthlyFee = 100,
                            OperatingCostPerYear = 2000,
                            YearOfConstruction = 2000,
                            ImageUrl = new List<string> { "image_url1", "image_url2" },
                            RealEstateAgent = agent5
                        };

                        await context.AddRangeAsync(new List<Firm> { firm1, firm2, firm3});
                        await context.AddRangeAsync(new List<RealEstateAgent> { agent1, agent2, agent3, agent4, agent5, agent6, agent7, agent8, agent9, agent10 });
                        await context.AddRangeAsync(new List<Municipality> { municipality1, municipality2, municipality3, municipality4, municipality5, municipality6, municipality7, municipality8, municipality9, municipality10 });
                        await context.AddRangeAsync(new List<Category> { category1, category2, category3, category4 });
                        await context.AddRangeAsync(new List<SaleObject> { saleObject1, saleObject2, saleObject3, saleObject4, saleObject5 });
                        await context.SaveChangesAsync();
                    }
                    }
                }
              */

        public async Task SeedCategoriesAsync(ApplicationDbContext applicationDbContext)
        {
            if (!applicationDbContext.Categories.Any())
            {
                var category1 = new Category("House");
                var category2 = new Category("Cottage");
                var category3 = new Category("Condo");
                var category4 = new Category("Terraced House");
                applicationDbContext.AddRange(category1, category2, category3, category4);
                await applicationDbContext.SaveChangesAsync();
            }
        }
        public async Task SeedSaleObjectsAsync(ApplicationDbContext applicationDbContext)
        {
            //Peter

            if (!applicationDbContext.SaleObjects.Any())
            {
                //get real estate agents
                RealEstateAgent stjarnhusAgent = await applicationDbContext.RealEstateAgents.FirstAsync(f => f.Email.Contains("stjarnhus"));
                RealEstateAgent hemlangtanAgent = await applicationDbContext.RealEstateAgents.FirstAsync(f => f.Email.Contains("hemlangtan"));
                RealEstateAgent elysiumAgent = await applicationDbContext.RealEstateAgents.FirstAsync(f => f.Email.Contains("elysium"));

                //get municipalities
                Municipality municipality1 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Härryda");
                Municipality municipality2 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Hjo");
                Municipality municipality3 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Umeå");
                Municipality municipality4 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Flen");
                Municipality municipality5 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Älmhult");
                Municipality municipality6 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Åre");

                //get firms
                Firm stjarnhusFirm = await applicationDbContext.Firms.FirstAsync(f => f.Name.Contains("Stjärnhus"));
                Firm hemlangtanFirm = await applicationDbContext.Firms.FirstAsync(f => f.Name.Contains("Hemlängtan"));
                Firm elysiumFirm = await applicationDbContext.Firms.FirstAsync(f => f.Name.Contains("Elysium"));

                //get categories
                Category category1 = applicationDbContext.Categories.FirstOrDefault(c => c.Name == "House");
                Category category2 = applicationDbContext.Categories.FirstOrDefault(c => c.Name == "Condo");
                Category category3 = applicationDbContext.Categories.FirstOrDefault(c => c.Name == "Cottage");
                Category category4 = applicationDbContext.Categories.FirstOrDefault(c => c.Name == "Terraced House");


                //create sales objects
                List<SaleObject> saleObjectList = new List<SaleObject>
                {
                    //seed houses
                    new SaleObject {Address = "Gärdhemsvägen 9", Municipality = municipality1 , Category = category1, StartingPrice = 2650000, LivingArea = 91, AncillaryArea = 91, PlotArea = 1083, Description = "Med en stor och lummig tomt om 1083 kvadratmeter erbjuder denna naturnära bostad en fridfull tillvaro. Här finns gott om utrymme för avkoppling och lek i den trevliga trädgården.", NumberOfRooms=4, MonthlyFee = 3852, OperatingCostPerYear = 46242, YearOfConstruction = 1964, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/54/1a/541a9dbb952f412bb911a2fb213f69f7.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/e6/7a/e67a852b662e2af3647db1bc12e10dda.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/a2/cc/a2cc1abd3dd7092cd111740665ef2d81.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/62/1b/621bac8feecf567561eaa6777f8a5191.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/fc/24/fc249039e65084b1d6113c3b7ab080f1.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/71/c4/71c4054346369bae8d42f13894e04047.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/d4/b4/d4b4f03357f672bcecd23249b023033e.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/fd/57/fd57f78810ee6b2a785345174e1279ff.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/4d/59/4d59aeacf5494a9eeadc7843fd560253.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/15/7c/157c0ecdc35bdfe501b351522b0dc92c.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/63/7d/637df48a4fc3b37e778dfa12f4ba2bf3.jpg" } ,RealEstateAgent = stjarnhusAgent},
                    new SaleObject {Address = "Slingervägen 57", Municipality = municipality2 , Category = category1, StartingPrice = 2195000, LivingArea = 197, AncillaryArea = 35, PlotArea =843, Description = "Med sina imponerande 197 kvadratmeter erbjuder detta hem gott om utrymme för den stora familjen eller möjligheter att skapa generösa sällskapsytor. Med hela åtta sovrum finns här gott plats för den som jobbar hemifrån eller driver eget. Villan har en lättskött trädgårdstomt med en stor altan i bästa söderläge!", NumberOfRooms=8, MonthlyFee = 3089, OperatingCostPerYear = 37072, YearOfConstruction = 1979, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/9d/a5/9da5a9a7e78a66b4267c1474a537e784.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/88/05/8805a738cf5fc41ae3a9a48fc343f05e.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/6a/94/6a94bcc17ce9336618816fa2816e92d4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/46/7a/467a5343526e523a2966a9bfb1d71d48.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/a3/c7/a3c742711644933aa8c513e41ae16b41.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/25/d3/25d3e4a5a89a34fdf03c62058b11db09.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/8a/c3/8ac3460e44a4891a62fff495a62e95a8.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/cb/e3/cbe37b28588fd4143439f31f1be01ed1.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/7a/7a/7a7abc4e1e9f0b2fb4e79e4fa4a89094.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/db/0e/db0ea55d3091b755e35c08d35d01889b.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/a5/a4/a5a48cfa39e606789d1666c98a4b4be4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/73/7c/737c35e21616951075cea131f9e32f08.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/29/3a/293a90004b72c2d4ba290c430e877883.jpg"} ,RealEstateAgent = elysiumAgent  },
                    new SaleObject {Address = "Tväråmark 63", Municipality = municipality3 , Category = category1, StartingPrice = 1875000, LivingArea = 82, AncillaryArea = 4, PlotArea = 1214, Description = "Huset ligger på en höjd med vacker utsikt och har sol på entrésidan fram till sena kvällen. Planlösningen erbjuder stort kök, vardagsrum med burspråk, två sovrum och wc/dusch. Till vänster om huset finns ett fristående garage med plats för en bil och en förrådsdel som är isolerad och uppvärmd. På huset baksida finns en större altan som fångar solen hela dagen.", NumberOfRooms=3, MonthlyFee = 2808, OperatingCostPerYear = 33703, YearOfConstruction = 1987, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/0a/18/0a18657bf2e78d6034374a732a7bfaf6.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/4f/d8/4fd891a1bf9735c533401978e9c38c27.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/24/2e/242e62111eb7e56cd94afa76c6f743f1.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/fb/25/fb25dcbada65e868ff6bb32172445f47.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/0c/73/0c7346b9cd82c011569be5873e734ba0.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/47/81/47817b7092383aea53cdc4fa0b9dea07.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/73/e7/73e754dafac3be5108eaf0e07a754ddf.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/3d/74/3d74e4b5fc782295e640bb25583cb6eb.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/32/38/3238dd752704944503c2e6604ac35391.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/06/14/0614dca0b8f064303800f8f567e7710b.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/d1/d3/d1d30f7b4c386fff4ad372d94a324ab6.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/ce/7a/ce7a6124ecec2bba1406240373a97e70.jpg"} ,RealEstateAgent = hemlangtanAgent  },
                    new SaleObject {Address = "Hagvägen 3", Municipality = municipality4 , Category = category1, StartingPrice = 2975000, LivingArea = 139, AncillaryArea = 68, PlotArea = 1346, Description = "Fin enplansvilla med källare med mycket renoverat löpande genom åren. Härlig baksida med uppvärmd pool, uterum, utekök, odlingslådor samt ett gästhus med förråd. Kök med öppen planlösning mot vardagsrum i fil med TV-rum. Badrum med kakel moch klinker både med hörnbadkar och dusch. Uppvärmning med bergvärme (-21) kompletterat med 33 solpaneler (-23). Carport med elbilsladdare installerad.", NumberOfRooms=5, MonthlyFee = 1916, OperatingCostPerYear = 23000, YearOfConstruction = 1950, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/61/11/611195eb2aee8fd0db91e79ec5ff639d.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/47/70/4770b63238460e8014120b3404384d7d.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/f8/2e/f82eddc4cb767016d4fa2d5af49d0ca3.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/38/3b/383b192e50cb2b13d7d3abbaddb117d8.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/f5/41/f5415911c2c8e084971a972c54bc1c88.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/8b/ae/8baebb64410ae86efa8511589a464297.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/89/76/89765314cfe1308c3234c539e2e2d194.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/c1/11/c111adf086ddcf711d76e6beb23fd1e1.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/32/c6/32c625bf7294db92da9001972488e663.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/09/a9/09a9fbcb9c27591a7e01bc01ae675ed4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/55/69/55695ec3789188f580974ec31c462d99.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/fe/ad/fead84d7bf096d3faf533ac58bc80a0d.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/f7/ac/f7acb52701074437d089882976c0ce6f.jpg"} ,RealEstateAgent = stjarnhusAgent},
                    new SaleObject {Address = "Baggåsvägen 26", Municipality = municipality5 , Category = category1, StartingPrice = 1395000, LivingArea = 108, AncillaryArea = 22, PlotArea = 2116, Description = "I lungt läge på Baggåsvägen 26 strax utanför Liatorp hittar du denna trevliga fastighet som ligger med naturen in på knuten. Här erbjuds fina boende ytor med möjlighet till aktiv hobby. Bostadshuset är i 1 1/2 plan med vidbyggt dubbelgarage och erbjuder 3-4 sovrum, vardagsrum med braskamin, badrum, kök, allrum, matrum med vedspis samt rejäl tvättstuga. Stort vidbyggt dubbelgarage med inredningsbar övervåning.", NumberOfRooms=6, MonthlyFee = 2425, OperatingCostPerYear = 29100, YearOfConstruction = 1938, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/9f/fa/9ffa28d8fdfc4d554fefbab681a84d16.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/2a/8c/2a8c5bb7f0b26cc5baed861b81a06818.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/1a/f3/1af3d0393aff9da09482023d326d7785.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/45/6b/456bef0889430f6aefa94aa20bfdb033.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/f2/2d/f22d319d9e368f1302e6285e44acbf83.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/77/9c/779c41009414c91d1073a854d2d710d4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/92/98/929890af453b3c7e980feba5d20fbb6d.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/04/c9/04c96d62a70577eac3f031b79f7fe741.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/6e/e1/6ee1de0daaeebcd6e4d896b440df79c2.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/4e/15/4e15294385de06a148e126a8b53d6b26.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/8b/38/8b380378db5a9d09284a63e075c7919b.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/1f/b7/1fb7f693cb40a6e01fa60c67084cdfbe.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/bb/45/bb456f8ffb11e2bdc0f0984640fa2d70.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/42/be/42be6b8c8051d1439566af34826416d7.jpg"} ,RealEstateAgent = stjarnhusAgent  },

                    //seed condos
                    new SaleObject {Address = "Dieselloksgatan 11C", Municipality = municipality1 , Category = category2, StartingPrice = 3650000, LivingArea = 99, AncillaryArea = 5, PlotArea = 0, Description = "Direkt när man kommer in i lägenheten möts man av den öppna och härliga planlösningen mellan kök och vardagsrum. Tilltalande Vedum-kök, helkaklat badrum med tvättdel, gäst-wc och tre sovrum med gott om förvaringsutrymmen och genomgående enstavsparkett. Två utgångar till den stora inglasade balkongen med skjutbara glas som har eftermiddags- och kvällssol samt utsikt ner mot kanalen.", NumberOfRooms=4, MonthlyFee = 6301, OperatingCostPerYear = 6000, YearOfConstruction = 2020, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/eb/c6/ebc6333893cf9eb8bc03c362486b8ac2.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/eb/56/eb563bf12f7348fa625a6f404b131ec7.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/b8/95/b8952e279624f771f2affe3550d107b8.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/47/3d/473d0dc63aecf2e7b6823837dd96c9a3.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/6f/da/6fda31dfbb59137976e57f89d31856ec.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/db/ca/dbcada4f35a6943d6704cfb70c4d5e88.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/a2/f7/a2f73ed4ae8e6afd0f93fe63ef923be2.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/91/27/91279ca196b71089728757f88130d3e8.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/14/24/1424eeb0c33d42a243c813076e031025.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/e5/01/e501b2ca5a338134b4fd11dc7f871ee7.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/80/6d/806d83e218824d48fad8ddf842b0be2d.jpg"} ,RealEstateAgent = stjarnhusAgent  },
                    new SaleObject {Address = "Lillängvägen 8B", Municipality = municipality6 , Category = category2, StartingPrice = 5100000, LivingArea = 107, AncillaryArea = 7, PlotArea = 0, Description = "Här kommer du som vill ha ljusinsläpp och  stora sociala ytor verkligen att trivas. Tack vare de stora och höga fönsterpartierna så ges bostaden en härlig rymd. När du parkerar bilen utanför så möts du av ett stort trädäck med inbjudande spabad och gott om plats för utemöbler, grill och odlingskrukor. Väl inne i huset finns gott om avhängning i hallen som har klinkers på golv. Badrummet  med bastu finns i direkt anslutning till entrén och det andra en våning upp.  Vardagsrum och kök har en härlig öppen planlösning med braskaminen i centrum. Köket är väl balanserat för dig att skapa härliga middagar i goda vänners lag samtidigt som spabadet och bastun kan värma trötta skidåkarben.  ", NumberOfRooms=5, MonthlyFee = 4203, OperatingCostPerYear = 53892, YearOfConstruction = 2019, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/2d/7a/2d7aa9f22410dec583f0984c00510a89.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/aa/07/aa07aca35096c619c3f7c6a8464966d1.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/0b/72/0b7213a97a301b49933b1b9cffd7502c.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/69/45/69451c1e8d86c6393353db2d0e14e712.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/16/57/165788a57adc35bbd4cf5471097ccb1f.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/d8/4e/d84e3bb4afc7592e2075b9ba55bac6ca.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/87/cc/87cc1aa1751289b0fad539d90cbb3d47.jpg"} ,RealEstateAgent = hemlangtanAgent  },
                    new SaleObject {Address = "Bollmoravägen 4", Municipality = municipality2 , Category = category2, StartingPrice = 1450000, LivingArea = 23, AncillaryArea = 2, PlotArea = 0, Description = "Bostaden präglas av ljusa och nyligen nymålade väggar och tak, rymligt och fullt utrustat kök med diskmaskin, halvstor kyl och frys, ugn, mikro samt induktionshäll. Fint helkaklat badrum med ljusa material med WC, handfat, dusch och kommod. Möjlighet till tvättmaskin finns. Sammanfattningsvis är detta en optimal bostad för dig som söker ett billigt och trivsamt boende med ett centralt läge till det mesta!", NumberOfRooms=1, MonthlyFee = 1988, OperatingCostPerYear = 2388, YearOfConstruction = 1964, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/95/fd/95fddcb0cbb49e1e275c3fa96555b0b5.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/32/85/3285c0ecbcc772c9e86bf53a64168732.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/01/d9/01d9706f8a050a084bf20eb1c3d398df.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/2d/35/2d35ae74515590f09802c081c98694ca.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/5d/63/5d63a5e11a176cd56ab437e5eeaab57a.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/b9/4a/b94a0329f77fb20225bb55950832ca71.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/2c/f6/2cf6baa7634f536512768a8f91384834.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/68/30/68303c9474a7168086f6838410212dad.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/e7/10/e710285bc6b8b5e74563bf1ed3ef8af0.jpg"} ,RealEstateAgent = elysiumAgent  },
                    new SaleObject {Address = "Plutos gränd 9F", Municipality = municipality3 , Category = category2, StartingPrice = 1295000, LivingArea = 52, AncillaryArea = 3, PlotArea = 0, Description = "Interiört möts vi av en härlig atmosfär där planlösningen är smart och tilltalande. Moderna och väl iordning gjorda ytskikt gör att det blir enkelt att trivas och flytta rakt in!\r\n\r\nBostaden disponerar ett fullutrustat IKEA kök med en praktisk köksmöbel som fungerar som en köksö. Öppen planlösning mellan kök och vardagsrum skapar härliga umgängesytor. Vidare finns här ett väl tilltaget sovrum, extra plus är att man valt att göra iordning walk-in-closeten till ett fint extra arbetsrum. Vidare erbjuds ett fräscht badrum utrustat med tvättmaskin. Guldkant på tillvaron ges på balkongen, belägen i ett skönt västerläge är detta en härlig plats att njuta och ha det gott på. \r\n", NumberOfRooms=2, MonthlyFee = 4095, OperatingCostPerYear = 8580, YearOfConstruction = 2009, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/ba/f3/baf3fe664061e18d936e02a5964fbd17.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/6d/ef/6def1cf6a1738a64750636a0aeb52269.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/11/4d/114d1e2d9a3a89fe0d26a6f821acf604.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/b4/8d/b48dc72e15ff7d6e2b070f8d3f50300a.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/b4/6d/b46de9370a71404e6a79633b120eadb4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/91/27/9127615fd734c702303fd0ff76535fcd.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/db/3a/db3a68723a16b4e01bd8f28e4160784f.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/91/f5/91f5df6c754451437bfcb6ea044024af.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/ee/5d/ee5d84b8a4304558633ab0c0ba65075b.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/66/b4/66b400a711215ed795b92fc35b848829.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/d2/d2/d2d26c34c3d848c0b151dd89655e9976.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/85/63/8563daf0605f5aef43c5aeedee9ac06b.jpg"} ,RealEstateAgent = stjarnhusAgent  },
                    new SaleObject {Address = "Fikonvägen 51", Municipality = municipality4 , Category = category2, StartingPrice = 2400000, LivingArea = 94, AncillaryArea = 3, PlotArea = 0, Description = "Med ett av områdets bästa lägen välkomnas du här till denna trivsamma fyrarumslägenhet i populära Älmhult. Både kök och de två badrummen är smakfullt renoverade. I köket finns plats för större matplats invid fönstret och det ena badrummet är utrustat med tvättmaskin. Tack vare hörnläget har bostaden ett fint ljusinsläpp från tre väderstreck. Balkongen på husets gavel i sydvästligt läge ger härligt solläge från lunch till sena kvällen. Välkommen att trivas!", NumberOfRooms=4, MonthlyFee = 4977, OperatingCostPerYear = 10900, YearOfConstruction = 1979, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/fe/21/fe218456fbf21d8e074d2102700550fc.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/62/e2/62e2b935f8cbdf8be3e4cee04c39d64c.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/67/f4/67f4fff2a90af24ecc375db98bbee94c.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/05/da/05da52c7a682d18ec5f1176009efd6ce.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/51/d0/51d072c3d1900befb23435b11d84fd04.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/a0/b1/a0b1007ae95e0001edfae11023b9b11e.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/0f/14/0f141e8f2fbb745a5430c01cae2f1fa5.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/ef/6e/ef6e6435a4b7fedfaa8bd675593cb621.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/90/a9/90a9e184cffb0cce04dd8ce83c4a42d6.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/2c/b6/2cb6ad6cca916e6836733d7882e902a7.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/98/22/982293276b95f49e60c440d31a10fce3.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/76/56/765647ad675331c8089795aa51f7074b.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/8b/de/8bde2c2b10d158a77a608a27a72863fd.jpg"} ,RealEstateAgent = hemlangtanAgent  },
                    
                   
                    //seed cottages
                    new SaleObject {Address = "Bollmoravägen 4", Municipality = municipality2 , Category = category2, StartingPrice = 1450000, LivingArea = 23, AncillaryArea = 2, PlotArea = 0, Description = "", NumberOfRooms=6, MonthlyFee = 2425, OperatingCostPerYear = 29100, YearOfConstruction = 1938, ImageUrl = new List<string>{ ""} ,RealEstateAgent = stjarnhusAgent  },
                    
                    //seed terranced houses
                    //peter
                    new SaleObject {Address = "Sandavägen 22", Municipality = municipality1 , Category = category4, StartingPrice = 4495000, LivingArea = 132, AncillaryArea = 34, PlotArea = 328, Description = "Huset ligger högt med magiskt fin utsikt och mycket bra solläge med eftermiddags och kvällssol beroende på årstid från den stora balkongen och trädgården med altan på baksidan. På framsidan finns två fina uteplatser som är stenlagda. Här finns även ett stort garage med goda förvarings utrymmen samt parkering för två bilar. ", NumberOfRooms=6, MonthlyFee = 3206, OperatingCostPerYear = 38473, YearOfConstruction = 1970, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/31/a6/31a6b5d2f6a7551a68d0c1bbb7cb86bb.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/e2/c5/e2c543b939896000718dfaa086b203fc.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/9d/e9/9de9bf561c715f165e8249274680899a.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/82/48/824869053dd9d0877f7f5fcf59e967fd.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/11/f0/11f0bc358528a2fa369873067a1c77b7.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/19/bc/19bc7dcc4c07583fc167fc5f4e650962.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/8d/03/8d03be90d86d46d41f56ed4dc1c4c24d.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/13/af/13afa5d03276ab0dbac21bc8c1fde6d0.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/2b/62/2b62cfa28d6e72d8fc09f37b5ad43419.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/64/d1/64d1845c26ae7f5e2951582d65839717.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/47/29/47295655e423aded317eb5a5633b7005.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/39/3d/393d1a0baa5bdcc76eb78b41f46c633c.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/8e/f5/8ef5862b49a2499fbdafa01bb9de9ec4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/73/93/73930100216595d559e5f7806751b9e3.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/9d/7d/9d7dab3820ef6f3fc713295f5ae4e3e8.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/dd/1f/dd1f3930254e8af7efe78b55c1f14152.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/fe/e1/fee1b4a9bba1ef3991e6840c7f39b3ed.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/c9/3d/c93d40ff20ee989240fb846ef5a4fc62.jpg"} ,RealEstateAgent = hemlangtanAgent  },
                    new SaleObject {Address = "Stuterivägen 25", Municipality = municipality2 , Category = category4, StartingPrice = 5290000, LivingArea = 134, AncillaryArea = 22, PlotArea = 127, Description = "Den här bostaden är ett under av god planering med exklusiva materialval tillsammans med trendig design. Här finner ni genomgående parkettgolv i 1-stavig vit ask och klinker med underliggande golvvärme på hela entréplan. Här lyckades arkitekten med konststycket att få in många rum och samtidigt få dem att kännas luftiga, stora och inbjudande med generösa fönsterpartier.", NumberOfRooms=5, MonthlyFee = 4959, OperatingCostPerYear = 13450, YearOfConstruction = 2017, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/7d/93/7d93c69a0ed8b96568c9671be4c1c967.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/f9/4a/f94a395ee18e02a85b12d02afe72723a.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/7c/5f/7c5f20fd347aebe560c013a2907767bb.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/0c/62/0c62cb84b5f7b82e613a46c465fa754f.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/3b/88/3b88a1c9019be8a9a4e096e2bf38ccea.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/da/ae/daae518aeea5431ed7cea7922d1c678f.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/85/bf/85bfb80e86fcce65505474d3b20eff98.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/73/c1/73c19e441f69b41d7d7b8547a9711714.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/04/5a/045a60dd45fff986a6f0d4b9b941fabb.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/70/1d/701dff2eb9bab344011a97367566a1c3.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/da/21/da2138a801cac6c521d7656f27006477.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/ae/76/ae762105d24fb22d9bbf8535bc5d82d8.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/f8/27/f82730fb943da5517f00d15476d593a4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/72/34/723453325418f2c7ec710a90e7b97967.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/94/3a/943a3beb6665378100b3e88ba99bd58d.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/84/01/8401f2795f4e07c8851d81decc036cd7.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/79/12/791247b9f734ad7a24ec34e9d61a0b03.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/d5/22/d5223f5851760912a25c6d1df088d664.jpg"} ,RealEstateAgent = elysiumAgent  },
                    new SaleObject {Address = "Ekvägen 19A", Municipality = municipality3 , Category = category4, StartingPrice = 2950000, LivingArea = 120, AncillaryArea = 16, PlotArea = 372, Description = "Med en boyta på 120 kvm fördelat över 5 rum, ivarav 4 sovrum, erbjuder detta hem gott om plats för hela familjen. Här finner du ett rymligt kök med matplats, ett ljust vardagsrum och praktiska utrymmen såsom tvättstuga, gästtoalett och badrum. Detta trevliga boende lockar med inte mindre än 2 soliga uteplatser, perfekta för avkoppling och umgänge under varma sommardagar. Dessutom finns gott om förvaringsmöjligheter, vilket underlättar vardagen.\r\n", NumberOfRooms=5, MonthlyFee = 5409, OperatingCostPerYear = 64912, YearOfConstruction = 1968, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/f3/20/f32074b6a1e9382e4e355a13d6c0b334.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/94/10/9410157319b084d3a1e7c94f5c3e14f1.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/bd/1e/bd1e885061649aabde659dd1bb0678b6.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/b5/4f/b54f29655bed185ba35b59a6ccbb4230.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/12/f8/12f808fce203fdfd97296ac998b7c76c.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/9f/a7/9fa77bdc1efa49a7a3a57996cc6c6604.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/4c/76/4c761d7ae045fc2ecce080e7e2ee02fe.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/58/8d/588d8577ee6ef9460677fe985fa9f82e.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/42/59/425959dffbffc8789c06eab4a1faf52b.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/1d/3f/1d3f2fa62e69e9cbe717e306be1aed51.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/d2/da/d2da929ee629dcd62713afde1fe78930.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/90/f2/90f259ab75648e52d3064c449d7d6b5d.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/da/8b/da8b1faefbb34ea0aa093793e619a28b.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/85/40/854024bd480f6ee7d29e989de92e499c.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/08/f3/08f3b336f470405b100e5101e8a88326.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/2f/73/2f73fadc7da43997a2a046cc83180fff.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/28/00/2800859de50a4b5bdfc81083877491a4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/a5/b8/a5b893c309925b5dbbb8776b404859aa.jpg"} ,RealEstateAgent = hemlangtanAgent  },
                    new SaleObject {Address = "Vällstavägen 3", Municipality = municipality4 , Category = category4, StartingPrice = 4495000, LivingArea = 123, AncillaryArea = 5, PlotArea = 0, Description = "Här bor du i ett modernt boende i barnvänligt område. Husen är väldisponerade med fina sällskapsytor som präglas av ljus och rymd. Vardagsrum i öppen planlösning mot köket med härligt ljusinsläpp. Fullt utrustat kök öppet mot matplats och vardagsrum. Tre sovrum som med enkla medel kan bli fyra. På entréplan finns kombinerat duschrum och tvättstuga och på den övre våningen finns såväl badrum som en mindre klädkammare. Från vardagsrummet nås den härliga uteplatsen och trädgården med altan och gräsytor - här är det bara att släppa ut barnen!", NumberOfRooms=5, MonthlyFee = 5261, OperatingCostPerYear = 22668, YearOfConstruction = 2019, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/95/2e/952ee0d5dd1e2903b1393d36529e73db.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/80/a2/80a226980c8ac3a09212803e797eaf6b.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/b5/a7/b5a72149974cc893b57b730ccded5353.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/ef/d3/efd300b49080dc42053d3b5d484e9888.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/ac/96/ac968e61e075404b06a46ee3cf6a0f43.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/dc/5c/dc5c7a14a7e6b6286bc4ebba0b5bcc27.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/ba/a6/baa6b687541f719759d2fa3f756eb278.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/ea/7c/ea7cc07c974d43e840be7701439ef86a.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/29/01/2901eb22f06b268e96304e8fe12d5b0a.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/13/a6/13a6adf29b5110f774a90c1ba8602343.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/ee/4a/ee4ad7b88c8b194401651f64a3187751.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/d3/bc/d3bc97f1b0b105cc1921dc88997cae6e.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/33/71/3371227089106039ec4ad1cd50cf550b.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/44/e9/44e9c63f58676cb7a4a695a9d2c6008a.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/85/db/85db18201702f5abd5ba2c370d50d727.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/48/a3/48a345fef68766dfa5e89844075af060.jpg"} ,RealEstateAgent = elysiumAgent  },
                    new SaleObject {Address = "Klappdansvägen 6", Municipality = municipality6 , Category = category4, StartingPrice = 2250000, LivingArea = 104, AncillaryArea = 155, PlotArea = 386, Description = "Välkommen till Klappdansvägen 6 och detta mycket praktiska hus som passar den stora familjen. Här uppenbarar sig massor av plats för lek och bus då undervåningen bjuder på stora ytor att leka på. Tomten ligger med soligt västerläge, här kan man njuta på den trevliga altanen som går att förädla. Boytan på 104 kvm är för delad på 3 sovrum (för närvarande 2), vardagsrum och kök. Dessutom har man 155 kvm i biyta där hela källaren och ett rymligt garage ingår. Alldeles i närheten har man Bulids underbara naturområde perfekt för härliga promenader eller andra aktiviteter, och Hovhultsskolan inom gångavstånd även för de minsta barnen. Fasaden är nyligen ommålad och utbytt där det behövdes.", NumberOfRooms=6, MonthlyFee = 3708, OperatingCostPerYear = 44500, YearOfConstruction = 1970, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/ad/6c/ad6c9a88afae9b22159f776d6f99381a.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/8a/d4/8ad44ab7f5b84c0805736c7deee4af30.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/5f/fb/5ffb21c54e897218e3f6ec7905d273c6.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/a3/c3/a3c37631bb71f8554c0a5c4d396684cf.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/b6/15/b61504b65e64656468ab5a98fe93c0d4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/7f/cd/7fcdab15b156fd07d71343de252b4a97.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/7d/bd/7dbd09f5b616bbee91417c0c5babd782.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/68/c8/68c839d2824c170776387f9266c47281.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/c4/4a/c44a48dfdb93bf02e172b8f55accfd1e.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/4b/86/4b862de13edd743a2fdcb60cbd921a01.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/db/f3/dbf3844fe70875a51acbf4318a188a5c.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/78/01/7801358ec6dfb658992bbf8a9a007a23.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/04/68/04680437b2f346fb0d45b3bcd4068d63.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/c0/14/c014516a55e1b1718a376354cc5dce0f.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/1e/5d/1e5d8cda5001ebae284b8ca5a7ac6347.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/3f/22/3f222382c655bcd63a5a9e1d0a18622b.jpg"} ,RealEstateAgent = elysiumAgent  },

                };

                applicationDbContext.AddRange(saleObjectList);
                await applicationDbContext.SaveChangesAsync();
            }
        }



        public async Task SeedFirmsAndAgentsAsync(ApplicationDbContext applicationDbContext)
        {
            //Henrik
            if (!applicationDbContext.Firms.Any())
            {
                var stjarnhusFirm = new Firm
                {
                    Name = "Stjärnhus Mäklartjänst",
                    Presentation = "Stjärnhus Mäklartjänst är en modern mäklarfirma som drivs av passion för att hjälpa kunder att hitta sina drömhem. Med innovativa marknadsföringsstrategier och en dedikerad team av fastighetsmäklare arbetar de för att maximera värdet för varje bostadsförsäljning och skapa en enastående kundupplevelse.",
                    ImageLocation = "placeholder.img",
                };

                var hemlangtanFirm = new Firm
                {
                    Name = "Hemlängtan Fastighetsmäkleri",
                    Presentation = "Hemlängtan Fastighetsmäkleri är en professionell mäklarfirma som specialiserar sig på att hjälpa kunder att hitta sitt drömhem. Med en passion för att skapa meningsfulla hem och en personlig touch i varje interaktion strävar de efter att göra köp- och säljprocessen så smidig och trevlig som möjligt för sina kunder.",
                    ImageLocation = "placeholder.img",
                };
                var elysiumFirm = new Firm
                {
                    Name = "Elysium Fastighetsförmedling",
                    Presentation = "Elysium Fastighetsförmedling strävar efter att förmedla bostäder som ger kunderna en känsla av himmelskt paradis. Med en djup förståelse för kundernas önskemål och behov arbetar de för att skapa en smidig och lyckad fastighetsaffär, där varje hem blir en oas av frid och skönhet.",
                    ImageLocation = "placeholder.img",
                };
                applicationDbContext.AddRange(stjarnhusFirm, hemlangtanFirm, elysiumFirm);
                await applicationDbContext.SaveChangesAsync();
            }


            //List<SaleObject> saleObjectList = new List<SaleObject>();
            if (!applicationDbContext.RealEstateAgents.Any())
            {
                Firm stjarnhusFirm = applicationDbContext.Firms.FirstOrDefault(f => f.Name.Contains("Stjärnhus"));
                Firm hemlangtanFirm = applicationDbContext.Firms.FirstOrDefault(f => f.Name.Contains("Hemlängtan"));
                Firm elysiumFirm = applicationDbContext.Firms.FirstOrDefault(f => f.Name.Contains("Elysium"));

                var stjarnhusAgent1 = new RealEstateAgent { FirstName = "Mats", LastName = "Sundin", Email = "mats@stjarnhus.com", PhoneNumber = "555-47874", Firm = stjarnhusFirm }; //SaleObjects = saleObjectList };

                var hemlangtanAgent1 = new RealEstateAgent { FirstName = "Niklas", LastName = "Lidström", Email = "niklas@hemlangtan.com", PhoneNumber = "599-435811", Firm = hemlangtanFirm }; //SaleObjects = saleObjectList };

                var elysiumAgent1 = new RealEstateAgent { FirstName = "Peter", LastName = "Forsberg", Email = "peter@elysium.com", PhoneNumber = "988-12447", Firm = elysiumFirm };

                applicationDbContext.AddRange(stjarnhusAgent1);
                applicationDbContext.AddRange(hemlangtanAgent1);
                applicationDbContext.AddRange(elysiumAgent1);
                await applicationDbContext.SaveChangesAsync();

            }

        }

        public async Task SeedMunicipalitiesAsync(ApplicationDbContext applicationDbContext)
        {
            //Thomas
            if (!applicationDbContext.Municipalities.Any())
            {
                List<Municipality> municipalityList = new List<Municipality>
                {

                    new Municipality("Härryda"),
                    new Municipality("Hjo"),
                    new Municipality("Umeå"),
                    new Municipality("Flen"),
                    new Municipality("Älmhult"),
                    new Municipality("Åre"),



                };
                applicationDbContext.AddRange(municipalityList);
                await applicationDbContext.SaveChangesAsync();
            };

        }

    }
}



