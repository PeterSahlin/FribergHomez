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
            if(!applicationDbContext.Categories.Any())
            {
                var category1 = new Category("House");
                var category2 = new Category("Cottage");
                var category3 = new Category("Condo");
                var category4 = new Category("Condo Terraced House");
                applicationDbContext.AddRange(category1, category2, category3, category4);
                await applicationDbContext.SaveChangesAsync();
            }
        }
        public async Task SeedSaleObjectsAsync(ApplicationDbContext applicationDbContext)
        {
            //Peter

            if (!applicationDbContext.SaleObjects.Any())
            {

                RealEstateAgent torontoAgent = await applicationDbContext.RealEstateAgents.FirstAsync(f => f.Email.Contains("Toronto"));
                RealEstateAgent pittsburghAgent = await applicationDbContext.RealEstateAgents.FirstAsync(f => f.Email.Contains("Pittsburgh"));
                RealEstateAgent coloradoAgent = await applicationDbContext.RealEstateAgents.FirstAsync(f => f.Email.Contains("Colorado"));

                //Added data
                Municipality municipality1 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Härryda");
                Municipality municipality2 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Hjo");
                Municipality municipality3 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Umeå");
                Municipality municipality4 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Flen");
                Municipality municipality5 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Älmhult");
                Municipality municipality6 = await applicationDbContext.Municipalities.FirstAsync(m => m.Name == "Åre");





                Firm firm1 = await applicationDbContext.Firms.FirstAsync(f => f.Name.Contains("Toronto"));
                Firm firm2 = await applicationDbContext.Firms.FirstAsync(f => f.Name.Contains("Pittsburgh"));
                Firm firm3 = await applicationDbContext.Firms.FirstAsync(f => f.Name.Contains("Colorado"));

                List<string> imgUrl = new List<string> { "www.test.com" };                                                          //ta bort när ej används
                //End of data part

                Category category1 = applicationDbContext.Categories.FirstOrDefault(c => c.Name == "House");
                Category category2 = applicationDbContext.Categories.FirstOrDefault(c => c.Name == "Condo");
                Category category3 = applicationDbContext.Categories.FirstOrDefault(c => c.Name == "Cottage");
                Category category4 = applicationDbContext.Categories.FirstOrDefault(c => c.Name == "Condo Terraced House");




                List<SaleObject> saleObjectList = new List<SaleObject>
                {
                    //seed houses
                    new SaleObject {Address = "Gärdhemsvägen 9", Municipality = municipality1 , Category = category1, StartingPrice = 2650000, LivingArea = 91, AncillaryArea = 91, PlotArea = 1083, Description = "Med en stor och lummig tomt om 1083 kvadratmeter erbjuder denna naturnära bostad en fridfull tillvaro. Här finns gott om utrymme för avkoppling och lek i den trevliga trädgården.", NumberOfRooms=4, MonthlyFee = 3852, OperatingCostPerYear = 46242, YearOfConstruction = 1964, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/54/1a/541a9dbb952f412bb911a2fb213f69f7.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/e6/7a/e67a852b662e2af3647db1bc12e10dda.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/a2/cc/a2cc1abd3dd7092cd111740665ef2d81.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/62/1b/621bac8feecf567561eaa6777f8a5191.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/fc/24/fc249039e65084b1d6113c3b7ab080f1.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/71/c4/71c4054346369bae8d42f13894e04047.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/d4/b4/d4b4f03357f672bcecd23249b023033e.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/fd/57/fd57f78810ee6b2a785345174e1279ff.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/4d/59/4d59aeacf5494a9eeadc7843fd560253.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/15/7c/157c0ecdc35bdfe501b351522b0dc92c.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/63/7d/637df48a4fc3b37e778dfa12f4ba2bf3.jpg" } ,RealEstateAgent = torontoAgent},
                    new SaleObject {Address = "Slingervägen 57", Municipality = municipality2 , Category = category1, StartingPrice = 2195000, LivingArea = 197, AncillaryArea = 35, PlotArea =843, Description = "Med sina imponerande 197 kvadratmeter erbjuder detta hem gott om utrymme för den stora familjen eller möjligheter att skapa generösa sällskapsytor. Med hela åtta sovrum finns här gott plats för den som jobbar hemifrån eller driver eget. Villan har en lättskött trädgårdstomt med en stor altan i bästa söderläge!", NumberOfRooms=8, MonthlyFee = 3089, OperatingCostPerYear = 37072, YearOfConstruction = 1979, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/9d/a5/9da5a9a7e78a66b4267c1474a537e784.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/88/05/8805a738cf5fc41ae3a9a48fc343f05e.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/6a/94/6a94bcc17ce9336618816fa2816e92d4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/46/7a/467a5343526e523a2966a9bfb1d71d48.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/a3/c7/a3c742711644933aa8c513e41ae16b41.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/25/d3/25d3e4a5a89a34fdf03c62058b11db09.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/8a/c3/8ac3460e44a4891a62fff495a62e95a8.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/cb/e3/cbe37b28588fd4143439f31f1be01ed1.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/7a/7a/7a7abc4e1e9f0b2fb4e79e4fa4a89094.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/db/0e/db0ea55d3091b755e35c08d35d01889b.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/a5/a4/a5a48cfa39e606789d1666c98a4b4be4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/73/7c/737c35e21616951075cea131f9e32f08.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/29/3a/293a90004b72c2d4ba290c430e877883.jpg"} ,RealEstateAgent = coloradoAgent  },
                    new SaleObject {Address = "Tväråmark 63", Municipality = municipality3 , Category = category1, StartingPrice = 1875000, LivingArea = 82, AncillaryArea = 4, PlotArea = 1214, Description = "Huset ligger på en höjd med vacker utsikt och har sol på entrésidan fram till sena kvällen. Planlösningen erbjuder stort kök, vardagsrum med burspråk, två sovrum och wc/dusch. Till vänster om huset finns ett fristående garage med plats för en bil och en förrådsdel som är isolerad och uppvärmd. På huset baksida finns en större altan som fångar solen hela dagen.", NumberOfRooms=3, MonthlyFee = 2808, OperatingCostPerYear = 33703, YearOfConstruction = 1987, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/0a/18/0a18657bf2e78d6034374a732a7bfaf6.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/4f/d8/4fd891a1bf9735c533401978e9c38c27.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/24/2e/242e62111eb7e56cd94afa76c6f743f1.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/fb/25/fb25dcbada65e868ff6bb32172445f47.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/0c/73/0c7346b9cd82c011569be5873e734ba0.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/47/81/47817b7092383aea53cdc4fa0b9dea07.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/73/e7/73e754dafac3be5108eaf0e07a754ddf.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/3d/74/3d74e4b5fc782295e640bb25583cb6eb.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/32/38/3238dd752704944503c2e6604ac35391.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/06/14/0614dca0b8f064303800f8f567e7710b.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/d1/d3/d1d30f7b4c386fff4ad372d94a324ab6.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/ce/7a/ce7a6124ecec2bba1406240373a97e70.jpg"} ,RealEstateAgent = pittsburghAgent  },
                    new SaleObject {Address = "Hagvägen 3", Municipality = municipality4 , Category = category1, StartingPrice = 2975000, LivingArea = 139, AncillaryArea = 68, PlotArea = 1346, Description = "Fin enplansvilla med källare med mycket renoverat löpande genom åren. Härlig baksida med uppvärmd pool, uterum, utekök, odlingslådor samt ett gästhus med förråd. Kök med öppen planlösning mot vardagsrum i fil med TV-rum. Badrum med kakel moch klinker både med hörnbadkar och dusch. Uppvärmning med bergvärme (-21) kompletterat med 33 solpaneler (-23). Carport med elbilsladdare installerad.", NumberOfRooms=5, MonthlyFee = 1916, OperatingCostPerYear = 23000, YearOfConstruction = 1950, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/61/11/611195eb2aee8fd0db91e79ec5ff639d.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/47/70/4770b63238460e8014120b3404384d7d.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/f8/2e/f82eddc4cb767016d4fa2d5af49d0ca3.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/38/3b/383b192e50cb2b13d7d3abbaddb117d8.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/f5/41/f5415911c2c8e084971a972c54bc1c88.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/8b/ae/8baebb64410ae86efa8511589a464297.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/89/76/89765314cfe1308c3234c539e2e2d194.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/c1/11/c111adf086ddcf711d76e6beb23fd1e1.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/32/c6/32c625bf7294db92da9001972488e663.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/09/a9/09a9fbcb9c27591a7e01bc01ae675ed4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/55/69/55695ec3789188f580974ec31c462d99.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/fe/ad/fead84d7bf096d3faf533ac58bc80a0d.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/f7/ac/f7acb52701074437d089882976c0ce6f.jpg"} ,RealEstateAgent = torontoAgent},
                    new SaleObject {Address = "Baggåsvägen 26", Municipality = municipality5 , Category = category1, StartingPrice = 1395000, LivingArea = 108, AncillaryArea = 22, PlotArea = 2116, Description = "I lungt läge på Baggåsvägen 26 strax utanför Liatorp hittar du denna trevliga fastighet som ligger med naturen in på knuten. Här erbjuds fina boende ytor med möjlighet till aktiv hobby. Bostadshuset är i 1 1/2 plan med vidbyggt dubbelgarage och erbjuder 3-4 sovrum, vardagsrum med braskamin, badrum, kök, allrum, matrum med vedspis samt rejäl tvättstuga. Stort vidbyggt dubbelgarage med inredningsbar övervåning.", NumberOfRooms=6, MonthlyFee = 2425, OperatingCostPerYear = 29100, YearOfConstruction = 1938, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/9f/fa/9ffa28d8fdfc4d554fefbab681a84d16.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/2a/8c/2a8c5bb7f0b26cc5baed861b81a06818.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/1a/f3/1af3d0393aff9da09482023d326d7785.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/45/6b/456bef0889430f6aefa94aa20bfdb033.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/f2/2d/f22d319d9e368f1302e6285e44acbf83.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/77/9c/779c41009414c91d1073a854d2d710d4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/92/98/929890af453b3c7e980feba5d20fbb6d.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/04/c9/04c96d62a70577eac3f031b79f7fe741.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/6e/e1/6ee1de0daaeebcd6e4d896b440df79c2.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/4e/15/4e15294385de06a148e126a8b53d6b26.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/8b/38/8b380378db5a9d09284a63e075c7919b.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/1f/b7/1fb7f693cb40a6e01fa60c67084cdfbe.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/bb/45/bb456f8ffb11e2bdc0f0984640fa2d70.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/42/be/42be6b8c8051d1439566af34826416d7.jpg"} ,RealEstateAgent = torontoAgent  },

                    //seed condos
                    new SaleObject {Address = "Dieselloksgatan 11C", Municipality = municipality1 , Category = category2, StartingPrice = 3650000, LivingArea = 99, AncillaryArea = 5, PlotArea = 0, Description = "Direkt när man kommer in i lägenheten möts man av den öppna och härliga planlösningen mellan kök och vardagsrum. Tilltalande Vedum-kök, helkaklat badrum med tvättdel, gäst-wc och tre sovrum med gott om förvaringsutrymmen och genomgående enstavsparkett. Två utgångar till den stora inglasade balkongen med skjutbara glas som har eftermiddags- och kvällssol samt utsikt ner mot kanalen.", NumberOfRooms=4, MonthlyFee = 6301, OperatingCostPerYear = 6000, YearOfConstruction = 2020, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/eb/c6/ebc6333893cf9eb8bc03c362486b8ac2.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/eb/56/eb563bf12f7348fa625a6f404b131ec7.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/b8/95/b8952e279624f771f2affe3550d107b8.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/47/3d/473d0dc63aecf2e7b6823837dd96c9a3.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/6f/da/6fda31dfbb59137976e57f89d31856ec.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/db/ca/dbcada4f35a6943d6704cfb70c4d5e88.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/a2/f7/a2f73ed4ae8e6afd0f93fe63ef923be2.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/91/27/91279ca196b71089728757f88130d3e8.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/14/24/1424eeb0c33d42a243c813076e031025.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/e5/01/e501b2ca5a338134b4fd11dc7f871ee7.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/80/6d/806d83e218824d48fad8ddf842b0be2d.jpg"} ,RealEstateAgent = torontoAgent  },
                    new SaleObject {Address = "Lillängvägen 8B", Municipality = municipality6 , Category = category2, StartingPrice = 5100000, LivingArea = 107, AncillaryArea = 7, PlotArea = 0, Description = " Här kommer du som vill ha ljusinsläpp och  stora sociala ytor verkligen att trivas. Tack vare de stora och höga fönsterpartierna så ges bostaden en härlig rymd. När du parkerar bilen utanför så möts du av ett stort trädäck med inbjudande spabad och gott om plats för utemöbler, grill och odlingskrukor. Väl inne i huset finns gott om avhängning i hallen som har klinkers på golv. Badrummet  med bastu finns i direkt anslutning till entrén och det andra en våning upp.  Vardagsrum och kök har en härlig öppen planlösning med braskaminen i centrum. Köket är väl balanserat för dig att skapa härliga middagar i goda vänners lag samtidigt som spabadet och bastun kan värma trötta skidåkarben.  ", NumberOfRooms=5, MonthlyFee = 4203, OperatingCostPerYear = 53892, YearOfConstruction = 2019, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/2d/7a/2d7aa9f22410dec583f0984c00510a89.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/aa/07/aa07aca35096c619c3f7c6a8464966d1.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/0b/72/0b7213a97a301b49933b1b9cffd7502c.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/69/45/69451c1e8d86c6393353db2d0e14e712.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/16/57/165788a57adc35bbd4cf5471097ccb1f.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/d8/4e/d84e3bb4afc7592e2075b9ba55bac6ca.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/87/cc/87cc1aa1751289b0fad539d90cbb3d47.jpg"} ,RealEstateAgent = pittsburghAgent  },
                    new SaleObject {Address = "Bollmoravägen 4", Municipality = municipality2 , Category = category2, StartingPrice = 1450000, LivingArea = 23, AncillaryArea = 2, PlotArea = 0, Description = "Bostaden präglas av ljusa och nyligen nymålade väggar och tak, rymligt och fullt utrustat kök med diskmaskin, halvstor kyl och frys, ugn, mikro samt induktionshäll. Fint helkaklat badrum med ljusa material med WC, handfat, dusch och kommod. Möjlighet till tvättmaskin finns. Sammanfattningsvis är detta en optimal bostad för dig som söker ett billigt och trivsamt boende med ett centralt läge till det mesta!", NumberOfRooms=1, MonthlyFee = 1988, OperatingCostPerYear = 2388, YearOfConstruction = 1964, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/95/fd/95fddcb0cbb49e1e275c3fa96555b0b5.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/32/85/3285c0ecbcc772c9e86bf53a64168732.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/01/d9/01d9706f8a050a084bf20eb1c3d398df.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/2d/35/2d35ae74515590f09802c081c98694ca.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/5d/63/5d63a5e11a176cd56ab437e5eeaab57a.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/b9/4a/b94a0329f77fb20225bb55950832ca71.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/2c/f6/2cf6baa7634f536512768a8f91384834.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/68/30/68303c9474a7168086f6838410212dad.jpg", "https://bilder.hemnet.se/images/itemgallery_portrait_cut/e7/10/e710285bc6b8b5e74563bf1ed3ef8af0.jpg"} ,RealEstateAgent = coloradoAgent  },
                    new SaleObject {Address = "Plutos gränd 9F", Municipality = municipality3 , Category = category2, StartingPrice = 1295000, LivingArea = 52, AncillaryArea = 3, PlotArea = 0, Description = "Interiört möts vi av en härlig atmosfär där planlösningen är smart och tilltalande. Moderna och väl iordning gjorda ytskikt gör att det blir enkelt att trivas och flytta rakt in!\r\n\r\nBostaden disponerar ett fullutrustat IKEA kök med en praktisk köksmöbel som fungerar som en köksö. Öppen planlösning mellan kök och vardagsrum skapar härliga umgängesytor. Vidare finns här ett väl tilltaget sovrum, extra plus är att man valt att göra iordning walk-in-closeten till ett fint extra arbetsrum. Vidare erbjuds ett fräscht badrum utrustat med tvättmaskin. Guldkant på tillvaron ges på balkongen, belägen i ett skönt västerläge är detta en härlig plats att njuta och ha det gott på. \r\n", NumberOfRooms=2, MonthlyFee = 4095, OperatingCostPerYear = 8580, YearOfConstruction = 2009, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/itemgallery_cut/ba/f3/baf3fe664061e18d936e02a5964fbd17.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/6d/ef/6def1cf6a1738a64750636a0aeb52269.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/11/4d/114d1e2d9a3a89fe0d26a6f821acf604.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/b4/8d/b48dc72e15ff7d6e2b070f8d3f50300a.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/b4/6d/b46de9370a71404e6a79633b120eadb4.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/91/27/9127615fd734c702303fd0ff76535fcd.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/db/3a/db3a68723a16b4e01bd8f28e4160784f.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/91/f5/91f5df6c754451437bfcb6ea044024af.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/ee/5d/ee5d84b8a4304558633ab0c0ba65075b.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/66/b4/66b400a711215ed795b92fc35b848829.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/d2/d2/d2d26c34c3d848c0b151dd89655e9976.jpg", "https://bilder.hemnet.se/images/itemgallery_cut/85/63/8563daf0605f5aef43c5aeedee9ac06b.jpg"} ,RealEstateAgent = torontoAgent  },
                    
                    
                    new SaleObject {Address = "Fikonvägen 51", Municipality = municipality2 , Category = category2, StartingPrice = 1450000, LivingArea = 23, AncillaryArea = 2, PlotArea = 0, Description = "", NumberOfRooms=6, MonthlyFee = 2425, OperatingCostPerYear = 29100, YearOfConstruction = 1938, ImageUrl = new List<string>{ ""} ,RealEstateAgent = torontoAgent  },



                    

                    //seed cottages
                    new SaleObject {Address = "Renlavsstigen 17", Municipality = municipality1 , Category = category2, StartingPrice = 1250000, LivingArea = 63, AncillaryArea = 410, PlotArea = 1190, Description = "Huset är bra planerat med tre sovrum och en tillhörande gäststuga om ca 10 kvm. Stor altan och härlig trädgård att kunna avnjuta sommarkvällarna på.", NumberOfRooms=4, MonthlyFee = 2258, OperatingCostPerYear = 27100, YearOfConstruction = 1976, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/1024x/db/1d/db1d380e541d98ad380ecb803736f148.jpg", "https://bilder.hemnet.se/images/1024x/92/63/92636f19061cc462a5635dd47db2c735.jpg", "https://bilder.hemnet.se/images/1024x/9d/4f/9d4f5489844816cd45350d2370530b28.jpg", "https://bilder.hemnet.se/images/1024x/26/de/26de845c40a1ed19ba6ab7fcbafb22d2.jpg", "https://bilder.hemnet.se/images/1024x/cd/4a/cd4a1ff65e6c28aa51fa59fc27f442a0.jpg", "https://bilder.hemnet.se/images/1024x/3b/c1/3bc15bdd31b8a4367a1208601000b74a.jpg", "https://bilder.hemnet.se/images/1024x/7b/de/7bde0c8f4e17c422eec11b7f8576da43.jpg", "https://bilder.hemnet.se/images/1024x/e6/af/e6af518b3306ea9c13f07193719d437c.jpg", "https://bilder.hemnet.se/images/1024x/76/76/76766f43172ad175a76a42507234a546.jpg", "https://bilder.hemnet.se/images/1024x/22/59/22595491938ee14f6894b0bf9bda387d.jpg" } ,RealEstateAgent = torontoAgent  },
                    new SaleObject {Address = "Bobergs Kustväg 7", Municipality = municipality2 , Category = category2, StartingPrice = 2200000, LivingArea = 58, AncillaryArea = 365, PlotArea = 1050, Description = "Varmt välkomna till detta fritidshus som ligger på ett naturskönt läge med närhet till havet! Nuvarande ägare hälsar att solen står på från lunch till solnedgång som man kan följa på den härliga verandan beläget på husets framsida. Här kan man även höra havet, och blir man sugen på ett kvälls- eller morgondopp så kan man promenera raka vägen ner och på ca 10 min så är man där! Med en härlig trädgård, med gärdsgård och ett växthus. På andra sidan gärdsgården kikar hästarna nyfiket in! ", NumberOfRooms=4, MonthlyFee = 3316, OperatingCostPerYear = 39793, YearOfConstruction = 1962, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/1024x/13/76/1376e54464b125d66e55ae15f947066f.jpg", "https://bilder.hemnet.se/images/1024x/7f/6d/7f6dc13552fe21082db27ad50c630a1a.jpg", "https://bilder.hemnet.se/images/1024x/84/e4/84e4cd70209ce4d47adc6dfea0b24103.jpg", "https://bilder.hemnet.se/images/1024x/dc/c1/dcc150d2f2c1e6d635d0bb350d07b348.jpg", "https://bilder.hemnet.se/images/1024x/1c/dd/1cddcfc326ad0882a79bbedd7bac5155.jpg", "https://bilder.hemnet.se/images/1024x/f3/6d/f36dc9db7b7ca72134ae97699cfe0bc2.jpg", "https://bilder.hemnet.se/images/1024x/ec/db/ecdb7e2a702ddfccbf55455d527d2ce5.jpg", "https://bilder.hemnet.se/images/1024x/92/38/9238944f876537bfb13162f719e101f2.jpg", "https://bilder.hemnet.se/images/1024x/66/dc/66dca3dd3ffb09f81fd2bd6ae7729a5c.jpg", "https://bilder.hemnet.se/images/1024x/28/69/28693acc0e3b8685c221a5686fc43485.jpg" } ,RealEstateAgent = pittsburghAgent  },
                    new SaleObject {Address = "Wientorpsvägen 1", Municipality = municipality3 , Category = category2, StartingPrice = 2495000, LivingArea = 79, AncillaryArea = 11, PlotArea = 2170, Description = "Upplev det söta livet i detta fritidshus med vackra planteringar, perfekt för avkoppling och nöje. Charmigt boende i vackra Umeå.", NumberOfRooms=3, MonthlyFee = 2610, OperatingCostPerYear = 31322, YearOfConstruction = 1978, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/1024x/2c/3a/2c3aee680d8ca3d0c3ffe4f11e338f5f.jpg", "https://bilder.hemnet.se/images/1024x/75/cf/75cf4ca24c36627449708360ed712267.jpg", "https://bilder.hemnet.se/images/1024x/33/42/3342c6d9380c7aa8107b9c1cb6683714.jpg", "https://bilder.hemnet.se/images/1024x/11/6c/116c76355fb991003e00a1d7ac8197a1.jpg", "https://bilder.hemnet.se/images/1024x/a4/30/a430de1205e0eea12d6cc8dbf1d41b85.jpg", "https://bilder.hemnet.se/images/1024x/84/24/8424aa42e0059d3090d052d65bd359ec.jpg", "https://bilder.hemnet.se/images/1024x/f3/3d/f33d0cd447db8191b77a8905880d92d1.jpg", "https://bilder.hemnet.se/images/1024x/d4/87/d48757a88b041b8c16d19ea825199dd5.jpg", "https://bilder.hemnet.se/images/1024x/d8/4c/d84c090f6202dba246ed8e121c4fbe4b.jpg", "https://bilder.hemnet.se/images/1024x/29/13/29138e2cbe66230b058abbd3a88c337d.jpg", "https://bilder.hemnet.se/images/1024x/b2/3a/b23a3b0e591b4f71b6fce11583b79ca3.jpg", "https://bilder.hemnet.se/images/1024x/3c/a2/3ca2f2aba3b4f2c8b237f67dd0266def.jpg" } ,RealEstateAgent = coloradoAgent  },
                    new SaleObject {Address = "Skärsbergets pumpväg 26", Municipality = municipality5 , Category = category2, StartingPrice = 2500000, LivingArea = 72, AncillaryArea = 25, PlotArea = 2363, Description = "Högt upp på Skärsberget, belägen på en mysig södervänd tomt ligger denna trevliga stuga som kan användas året om. Bra planlösning med 3 sovrum, kök, vardagsrum med öppen spis och badrum med dusch. Altan mot baksidan och fin förstukvist på framsidan. Källare består av tvättstuga och förrådsutrymmen med full ståhöjd.", NumberOfRooms=4, MonthlyFee = 2351, OperatingCostPerYear = 28212, YearOfConstruction = 1979, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/1024x/53/99/5399b900d8d4688a3a052db3993d5ba1.jpg", "https://bilder.hemnet.se/images/1024x/ef/b8/efb89500081ed1be54a20d7aa3f68033.jpg", "https://bilder.hemnet.se/images/1024x/2a/a0/2aa099a87b4b4f7f67817a18b16eed47.jpg", "https://bilder.hemnet.se/images/1024x/fa/ea/faea04a095e5ad0a6b72b0f72fc9d519.jpg", "https://bilder.hemnet.se/images/1024x/93/af/93af64aade84336ac09441e9f9c3a69a.jpg", "https://bilder.hemnet.se/images/1024x/11/80/1180efc4e430766be463dd59bff057ee.jpg", "https://bilder.hemnet.se/images/1024x/35/3b/353bfb8726c28e1cb8661a760366e321.jpg", "https://bilder.hemnet.se/images/1024x/e0/0b/e00bc375465a658214381950a60a80d4.jpg", "https://bilder.hemnet.se/images/1024x/77/cf/77cf614c5cf43e259c79672a80b48aa5.jpg", "https://bilder.hemnet.se/images/1024x/5a/a6/5aa687d13b5c43439973a16834751e3f.jpg", "https://bilder.hemnet.se/images/1024x/e2/83/e283c877d843a14df606dda097a2644e.jpg" } ,RealEstateAgent = pittsburghAgent  },
                    new SaleObject {Address = "Vassbäcksvägen 1", Municipality = municipality6 , Category = category2, StartingPrice = 1595000, LivingArea = 64, AncillaryArea = 16, PlotArea = 1531, Description = "Vassbäcksvägen ligger lite avskiljt med ett behagligt och skyddat läge som du når genom att följa Strandvägen några hundra meter söder om fiskeläget. Fastigheten erbjuder bostadshus uppfört i timmer omfattandes ett stort allrum med köksdel, två sovrum samt duschrum med wc. Utöver huvudstugan finns även en timrad gäststuga som är sammankopplad med bostadsstugan via en vindskyddad uteplats under tak.", NumberOfRooms=3, MonthlyFee = 1436, OperatingCostPerYear = 17241, YearOfConstruction = 1963, ImageUrl = new List<string>{ "https://bilder.hemnet.se/images/1024x/d8/73/d873ccd36d9ad4b89e0386445d0d88c0.jpg", "https://bilder.hemnet.se/images/1024x/af/14/af1468fcbfccedfa69c43b75f1e9c4bf.jpg", "https://bilder.hemnet.se/images/1024x/8b/78/8b786c186f1cd026d574077ab63ec486.jpg", "https://bilder.hemnet.se/images/1024x/47/3d/473d7bd3a64817f54d123aea462aaeb8.jpg", "https://bilder.hemnet.se/images/1024x/db/c5/dbc5285ac62e05927630b6c7529dffed.jpg", "https://bilder.hemnet.se/images/1024x/ac/21/ac21e974be520ff07e65cc7b1b1a38e1.jpg", "https://bilder.hemnet.se/images/1024x/32/85/3285080cc0e1718741b004e03f96d8a8.jpg", "https://bilder.hemnet.se/images/1024x/43/4e/434ee25f6c1d211543d811ec2bc31ea8.jpg", "https://bilder.hemnet.se/images/1024x/6c/55/6c55875f93873c63d62a81a45db7a082.jpg", "https://bilder.hemnet.se/images/1024x/82/81/82815732513eacadbb145f35c999fb42.jpg", "https://bilder.hemnet.se/images/1024x/49/f2/49f2fef2adca8d0751fcb01e57e34e8d.jpg" } ,RealEstateAgent = coloradoAgent  },

                    //seed condo terranced houses
                    new SaleObject {Address = "Bollmoravägen 4", Municipality = municipality2 , Category = category2, StartingPrice = 1450000, LivingArea = 23, AncillaryArea = 2, PlotArea = 0, Description = "", NumberOfRooms=6, MonthlyFee = 2425, OperatingCostPerYear = 29100, YearOfConstruction = 1938, ImageUrl = new List<string>{ ""} ,RealEstateAgent = torontoAgent  },



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
                var torontoFirm = new Firm
                {
                    Name = "Toronto Firm",
                    Presentation = "Toronto's finest housing",
                    ImageLocation = "MapleLeaf.img",
                    //RealEstateAgents = listOfTorontoAgents
                };

                var pittsburghFirm = new Firm
                {
                    Name = "Pittsburgh Firm",
                    Presentation = "Pittsburgh's finest housing",
                    ImageLocation = "Penguins.img",
                    //RealEstateAgents = listOfPittsburghAgents
                };
                var coloradoFirm = new Firm
                {
                    Name = "Colorado Firm",
                    Presentation = "Colorado's finest housing",
                    ImageLocation = "Avalanche.img",
                    //RealEstateAgents = listOfColoradoAgents
                };
                applicationDbContext.AddRange(torontoFirm, pittsburghFirm, coloradoFirm);
                applicationDbContext.SaveChanges();
            }


            List<SaleObject> saleObjectList = new List<SaleObject>();
            if (!applicationDbContext.RealEstateAgents.Any())
            {
                Firm torontoFirm = applicationDbContext.Firms.FirstOrDefault(f => f.Name.Contains("Toronto"));
                Firm pittsburghFirm = applicationDbContext.Firms.FirstOrDefault(f => f.Name.Contains("Pittsburgh"));
                Firm coloradoFirm = applicationDbContext.Firms.FirstOrDefault(f => f.Name.Contains("Colorado"));

                var torontoAgent = new RealEstateAgent { FirstName = "Mats", LastName = "Sundin", Email = "mats@toronto.com", PhoneNumber = "555-47874", Firm = torontoFirm }; //SaleObjects = saleObjectList };

                var pittsburghAgent = new RealEstateAgent { FirstName = "Jaromir", LastName = "Jagr", Email = "jaromir@pittsburgh.com", PhoneNumber = "599-435811", Firm = pittsburghFirm }; //SaleObjects = saleObjectList };

                var coloradoAgent = new RealEstateAgent { FirstName = "Peter", LastName = "Forsberg", Email = "peter@colorado.com", PhoneNumber = "988-12447", Firm = coloradoFirm };

                applicationDbContext.AddRange(torontoAgent);
                applicationDbContext.AddRange(pittsburghAgent);
                applicationDbContext.AddRange(coloradoAgent);
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
                new Municipality { Name = "Ale" },
                new Municipality { Name = "Alingsås" },
                new Municipality { Name = "Alvesta" },
                new Municipality("Aneby"),
                new Municipality("Arboga"),
                new Municipality("Arjeplog"),
                new Municipality("Arvidsjaur"),
                new Municipality("Arvika"),
                new Municipality("Askersund"),
                new Municipality("Avesta"),
                new Municipality("Bengtsfors"),
                new Municipality("Berg"),
                new Municipality("Bjurholm"),
                new Municipality("Bjuv"),
                new Municipality("Boden"),
                new Municipality("Bollebygd"),
                new Municipality("Bollnäs"),

                new Municipality("Härryda"),
                new Municipality("Hjo"),
                new Municipality("Umeå"),
                new Municipality("Flen"),
                new Municipality("Älmhult"),
                new Municipality("Åre"),



                };
                applicationDbContext.AddRange(municipalityList);
                applicationDbContext.SaveChanges();
            };

        }

    }
}



