using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CultureOfPakistan
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<Picture> _pictureStorage;
        public static List<Punjab> _punjabStorage;
        public static List<Sindh> _sindhStorage;
        public static List<Balochistan> _balochistanStorage;
        public static List<Kpk> _kpkStorage;
        public static List<Gilgitbaltistan> _gilgitbaltistanStorage;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            

            _sindhStorage = StorageClass.ReadXML<List<Sindh>>("SindhDetail.xml");
            if (_sindhStorage == null)
                _sindhStorage = new List<Sindh>();

            _balochistanStorage = StorageClass.ReadXML<List<Balochistan>>("BalochistanDetail.xml");
            if (_balochistanStorage == null)
                _balochistanStorage = new List<Balochistan>();

            _punjabStorage = StorageClass.ReadXML<List<Punjab>>("PunjabDetail.xml");
            if (_punjabStorage == null)
                _punjabStorage = new List<Punjab>();
           
            _kpkStorage = StorageClass.ReadXML<List<Kpk>>("KpkDetail.xml");
            if (_kpkStorage == null)
                _kpkStorage = new List<Kpk>();

            _gilgitbaltistanStorage = StorageClass.ReadXML<List<Gilgitbaltistan>>("GilgitbaltistanDetail.xml");
            if (_gilgitbaltistanStorage == null)
                _gilgitbaltistanStorage = new List<Gilgitbaltistan>();
        }



        private void Application_Exit(object sender, ExitEventArgs e)
        {


             Sindh sindhFestivalsPic1 = new Sindh { regionID = "1", ID = "Festivals", Images = "sindhiCultureDay.JPG", description = "Sindhi Cultural Day", largeDescription = "Sindhi Cultural Day also known as 'Aekta jo ddihaarro', is widely celebrated with traditional enthusiasm to spotlight the centuries-old rich culture of Sindh. The day is celebrated all over Sindh, and amongst the Sindhi diaspora around the world. Cultural day is the celebration, demonstration of culture of Sindh." };

            Sindh sindhFestivalsPic2 = new Sindh { regionID = "1", ID = "Festivals", Images = "sindhiCultureDay1.JPG", description = "Sindhi Cultural Day", largeDescription = "Sindhi Cultural Day also known as 'Aekta jo ddihaarro', is widely celebrated with traditional enthusiasm to spotlight the centuries-old rich culture of Sindh. The day is celebrated all over Sindh, and amongst the Sindhi diaspora around the world. Cultural day is the celebration, demonstration of culture of Sindh." };

            Sindh sindhFestivalsPic3 = new Sindh { regionID = "1", ID = "Festivals", Images = "sindhiDewaliInKhi.jpg", description = "Dewali festival in Karachi", largeDescription = "Hindu community celebrated dewali event at their temples through gatherings of families and decorating their houses and temples with colourful lights." };

            
            Sindh sindhFoodPic1 = new Sindh { regionID = "1", ID = "Cuisine", Images = "sindhiChanaPuri.jpg", description = "Channa Puri", largeDescription = "Chana Puri is an unleavened deep-fried bread, originating from the Indian subcontinent. It is eaten for breakfast in sindh province of Pakistan or as a snack or light meal. It is usually served with a chana curry or bhaji, as in Puri bhaji, but may also be eaten with sweet dishes.." };

            Sindh sindhFoodPic2 = new Sindh { regionID = "1", ID = "Cuisine", Images = "sindhiBiryani.jpg", description = "Sindhi Biryani", largeDescription = "Sindhi Biryani is a special meat and rice biryani dish originating from the Sindh province of Pakistan. Owing to its popularity, it forms one of the most consumed dishes of Pakistani cuisine and Sindhi cuisine." };

            Sindh sindhFoodPic3 = new Sindh { regionID = "1", ID = "Cuisine", Images = "sindhiRabri.jpg", description = "Rabri", largeDescription = "Rabri  is a famous sweet from Hyderabad, Sind,  Pakistan, by condensed-milk-based dish,  by boiling the milk on low heat for a long time until it becomes dense and changes its color to pinkish. Sugar, spices and nuts are added to it to give it flavor. It is chilled and served as dessert." };


            Sindh sindhPlacesPic1 = new Sindh { regionID = "1", ID = "Places to visit", Images = "sindhiMoenjoDaro.JPG", description = "Mohenjo-Daro", largeDescription = "Mohenjo-daro ‎, meaning 'Mound of the Dead Men' is an archaeological site in the province of Sindh, Pakistan. Built around 2500 BCE, it was one of the largest settlements of the ancient Indus Valley Civilisation, and one of the world's earliest major cities, contemporaneous with the civilizations of ancient Egypt, Mesopotamia, Minoan Crete, and Norte Chico." };

            Sindh sindhPlacesPic2 = new Sindh { regionID = "1", ID = "Places to visit", Images = "sindhiEmpressMarket.jpg", description = "Empress Market", largeDescription = "The Empress Market was constructed between 1884 and 1889 and was named to commemorate Queen Victoria, Empress of India. The market was constructed at a well-chosen site that was clearly visible from a great distance. The site of the market had historical significance as it was situated on the grounds where a number of native sepoys were executed in a ruthless fashion after the Sepoy Mutiny of 1857." };

            Sindh sindhPlacesPic3 = new Sindh { regionID = "1", ID = "Places to visit", Images = "sindhiRanikotFort.jpg", description = "Ranikot Fort", largeDescription = "Ranikot Fort also known as Rannikot) is a historical Talpur fort near Sann, Jamshoro District, Sindh, Pakistan. Ranikot Fort is also known as The Great Wall of Sindh and is believed to be the world's largest fort.  with a circumference of approximately 32 kilometres (20 mi). The fort's ramparts have been compared to the Great Wall of China." };


            Sindh sindhDressesPic1 = new Sindh { regionID = "1", ID = "Traditional Dress", Images = "sindhiAjrakKoti.jpg", description = "Sindhi Mens Dress", largeDescription = "The Sindhi kurta is the traditional straight cut variety which is made up of  local patterns of embroider the garment and also makes use of mirrors. The local art of bandhani (creating patterned textiles by resisting parts of a fabric by tying knots on it before it is dyed) is utilized which is believed to have originated in Sindh and spread to Gujarat via Rajasthan and is also practiced in the Punjab region. Sindhi kurtas are also made out of heavy local material called rilli and the kurtas are often called rilli kurtas.  Ajrak prints are also used." };

            Sindh sindhDressesPic2 = new Sindh { regionID = "1", ID = "Traditional Dress", Images = "sindhiAjrak.JPG", description = "Ajrak", largeDescription = "The traditional sindhi women dress is lengha (jablo) choli which is  worn by women in various parts of Sindh. Women in the Thakparkar district wear a ghagra, a heavier version of the lehnga, with either a loose or fitted choli, or a kancera, a fully embroidered, backless blouse, held on by small cap sleeves and strings." };

            Sindh sindhDressesPic3 = new Sindh { regionID = "1", ID = "Traditional Dress", Images = "sindhiShaziaKhushk.jpg", description = "Sindhi Womens Dress", largeDescription = "The traditional sindhi women dress is lengha (jablo) choli which is  worn by women in various parts of Sindh. Women in the Thakparkar district wear a ghagra, a heavier version of the lehnga, with either a loose or fitted choli, or a kancera, a fully embroidered, backless blouse, held on by small cap sleeves and strings." };



            Balochistan balochistanFestivalsPic1 = new Balochistan { regionID = "2", ID = "Festivals", Images = "balochistanBolanJeepRally.jpg", description = "Bolan Jeep Rally", largeDescription = "QUETTA: The three-day Bolan Jeep Rally. The rally, organized by the Balochistan government and Head Quarters Southern Command, in which a large number of prominent race drivers and sports adventurers, Women drivers are also taking part in the second Bolan Jeep Rally." };

            Balochistan balochistanFestivalsPic2 = new Balochistan { regionID = "2", ID = "Festivals", Images = "balochistanFolkFestivalSibi.jpg", description = "Sibi Mela", largeDescription = "The Sibi Mela is an annual cultural show held in Sibi from 24-28 February, in the Balochistan Province of Pakistan. The first Sibi Mela was held in Sibi in January 1885.[1] It has subsequently developed into a cultural festival, with animal markets, camel racing, tent pegging and exhibitions of handicrafts, tribal dresses and folk dances." };

            Balochistan balochistanFestivalsPic3 = new Balochistan { regionID = "2", ID = "Festivals", Images = "balochistanSibiMela.jpg", description = "Sibi Mela", largeDescription = "The Sibi Mela is an annual cultural show held in Sibi from 24-28 February, in the Balochistan Province of Pakistan. The first Sibi Mela was held in Sibi in January 1885. It has subsequently developed into a cultural festival, with animal markets, camel racing, tent pegging and exhibitions of handicrafts, tribal dresses and folk dances.." };

            Balochistan balochistanFoodPic1 = new Balochistan { regionID = "2", ID = "Cuisine", Images = "balochistanTraditionalStyleBreakfast.jpg", description = "Chayee Paratha", largeDescription = "Chayee Paratha meaning (tea with bread and butter) is balochistan’s traditional breakfast." };

            Balochistan balochistanFoodPic2 = new Balochistan { regionID = "2", ID = "Cuisine", Images = "balochistanSajji.jpg", description = "Sajji", largeDescription = "Sajji is a dish originating from the Balochistan province of Pakistan. It consists of whole lamb or chicken, in skewers (fat and meat intact), marinated only in salt, sometimes covered with green papaya paste, stuffed with rice, then roasted over coals. Sajji is considered done when it is at the 'rare' stage. It is served with a special bread Kaak, roti or naan, which is baked in an oven, wrapped around a stone tandoor" };

            Balochistan balochistanFoodPic3 = new Balochistan { regionID = "2", ID = "Cuisine", Images = "balochistaKkhaddi.jpg", description = "Khaddi Kabab", largeDescription = "Khaddi Kebab is a traditional Balochi food in which full lamb is barbecued in an underground space and put fire on the peak of the iron sheet wrapping the trenched space. Rice is also cooked inside the full lamb by well-trained professionals who know the art of cooking this delicious food. It normally weights around 10-12 kg that can be eaten by too many people at a time. The combination of rice and meat makes this dish too much delicious so that it is very hard to resist it." };

            Balochistan balochistanPlacesPic1 = new Balochistan { regionID = "2", ID = "Places to visit", Images = "balochistanBolanPass.jpg", description = "Bolan Pass", largeDescription = "The Bolān Pass is a mountain pass through the Toba Kakar Range of Balochistan province in western Pakistan, 120 km (75 mi) from the Afghanistan border. The pass is an 89 km (55 mi) stretch of the Bolan river valley from Rindli in the south to Darwāza near Kolpur in the north. It is made up of a number of narrow gorges and stretches." };

            Balochistan balochistanPlacesPic2 = new Balochistan { regionID = "2", ID = "Places to visit", Images = "balochistanKundMalir.jpg", description = "Kund Malir", largeDescription = "Kund Malir' is a beach in Balochistan, Pakistan located in Hingol National Park, about 150 kilometres (93 mi) from Zero-Point on Makran Coastal Highway. The drive between Kund Malir and Ormara is considered to be scenic. The area is part of Hingol National Park which is the largest in Pakistan. Traveling time from Karachi is around 4 hours and 03 hours from Gwadar." };

            Balochistan balochistanPlacesPic3 = new Balochistan { regionID = "2", ID = "Places to visit", Images = "balochistanZiaratResidency.jpg", description = "Ziarat Recidency", largeDescription = "Quaid-e-Azam Residency, also known as Ziarat Residency, is located in Ziarat, Balochistan, Pakistan. It is where Quaid-e-Azam, Muhammad Ali Jinnah spent the last two months and ten days of his life, nursed by A. S. Nathaniel. It is the most famous landmark of the city, constructed in 1892 during the British Raj. The building is a wooden structure, originally designed as a sanatorium before being converted into the summer residence of the agent of the Governor General. It is declared a national monument and heritage site and is of great architectural importance." };

            Balochistan balochistanDressesPic1 = new Balochistan { regionID = "2", ID = "Traditional Dress", Images = "balochistanMensDress.jpg", description = "Baloch Mens Dress", largeDescription = "The men's shalwar kameez consists of a very baggy shalwar  which uses large lengths of cloth. The kameez is also loose, which traditionally is long with long sleeves  The Balochi shalwar kameez is similar to the styles worn in Afghanistan. The present Balochi shalwar kameez replaced the earlier version which consisted of a robe to the ankles and a shalwar using cloth of up to 40 yards." };

            Balochistan balochistanDressesPic2 = new Balochistan { regionID = "2", ID = "Traditional Dress", Images = "balochistanMensDress1.jpg", description = "Baloch Mens Dress", largeDescription = "The men's shalwar kameez consists of a very baggy shalwar  which uses large lengths of cloth. The kameez is also loose, which traditionally is long with long sleeves  The Balochi shalwar kameez is similar to the styles worn in Afghanistan. The present Balochi shalwar kameez replaced the earlier version which consisted of a robe to the ankles and a shalwar using cloth of up to 40 yards." };

            Balochistan balochistanDressesPic3 = new Balochistan { regionID = "2", ID = "Traditional Dress", Images = "balochistanWomenDress.jpg", description = "Baloch Womens Dress", largeDescription = "The female Balochi suit consists of the head scarf, long dress and a shalwar. Balochi women wear loose dresses which are embroidered in local designs which include Balochi silk-thread chain-stitch embroidery. Balochi embroidery alone has 118 different basic designs." };



            Punjab punjabFestivalsPic1 = new Punjab { regionID = "3", ID = "Festivals", Images = "punjabBasantLahore.jpg", description = "Basant Festival Lahore", largeDescription = "The Basant Kite Festival Lahore has been a historic spring time kite flying event during the Basant Panchami festival in the Punjab region Pakistan. It falls on Basant, also called Basant Panchami, held in late January or early." };

            Punjab punjabFestivalsPic2 = new Punjab { regionID = "3", ID = "Festivals", Images = "punjabBasantKiteFlying.jpg", description = "Basant Festival Lahore", largeDescription = "The Basant Kite Festival Lahore has been a historic spring time kite flying event during the Basant Panchami festival in the Punjab region Pakistan. It falls on Basant, also called Basant Panchami, held in late January or early." };

            Punjab punjabFestivalsPic3 = new Punjab { regionID = "3", ID = "Festivals", Images = "punjabBasant.jpg", description = "Basant Festival Lahore", largeDescription = "The Basant Kite Festival Lahore has been a historic spring time kite flying event during the Basant Panchami festival in the Punjab region Pakistan. It falls on Basant, also called Basant Panchami, held in late January or early." };



            Punjab punjabFoodPic1 = new Punjab { regionID = "3", ID = "Cuisine", Images = "punjabCholeBhatura.jpg", description = "Chola Bhatura", largeDescription= "Chhole bhature is a dish from the Punjab region in the northern part of the Pakistan. This Punjabi dish is a combination of chana masala (spicy white chickpeas) and bhatura, a fried bread made from maida flour (soft wheat)." };

            Punjab punjabFoodPic2 = new Punjab { regionID = "3", ID = "Cuisine", Images = "punjabLahoriChickenTikka.jpg", description = "Chicken Tikka", largeDescription = "Chicken tikka is a chicken dish originating in the Punjab region in the northern part of the Pakistan; the dish is popular in Pakistan, India and Bangladesh. It is traditionally small pieces of boneless chicken baked using skewers on a brazier called angeethi after marinating in Indian spices and dahi (yogurt)—essentially a boneless version of tandoori chicken." };

            Punjab punjabFoodPic3 = new Punjab { regionID = "3", ID = "Cuisine", Images = "punjabSohnHalwa.jpg", description = "Sohan Halwa", largeDescription = "Sohan halwa  is a traditional dessert in Punjab and the Indian subcontinent, which is a variety of dense, sweet confection or halwa. Gheewala halwa is popular for sohan halwa since the Mughal era." };

            Punjab punjabPlacesPic1 = new Punjab { regionID = "3", ID = "Places to visit", Images = "punjabFaisalMosqueFaisal.jpg", description = "Faisal Masjid", largeDescription = "Faisal Mosque is a mosque in Islamabad, Pakistan. It is located on the foothills of Margalla Hills in Islamabad, the mosque features a contemporary design consisting of eight sides of concrete shell and is inspired by a Bedouin tent. The mosque is a major tourist attraction, and is referred as a contemporary and influential feature of Islamic architecture." };

            Punjab punjabPlacesPic2 = new Punjab { regionID = "3", ID = "Places to visit", Images = "punjabMinar-e-Pakistan.jpg", description = "Minar-e-Pakistan", largeDescription = "Minar-e-Pakistan  is a national monument located in Lahore, Pakistan. The tower was built between 1960 and 1968 on the site where the All-India Muslim League passed the Lahore Resolution on 23 March 1940 - the first official call for a separate and independent homeland for the Muslims of British India." };

            Punjab punjabPlacesPic3 = new Punjab { regionID = "3", ID = "Places to visit", Images = "punjabShahiMasjid.jpg", description = "Badshahi Masjid", largeDescription = "The Badshahi Mosque, or Imperial Mosque is a Mughal era masjid in Lahore. The mosque is located west of Lahore Fort along the outskirts of the Walled City of Lahore, and is widely considered to be one of Lahore's most iconic landmarks, The Badshahi Mosque was commissioned by Emperor Aurangzeb in 1671. The mosque is an important example of Mughal architecture, It remains the largest and most recent of the grand imperial mosques of the Mughal-era, and is now one of Pakistan's most iconic sights." };

            Punjab punjabDressesPic1 = new Punjab { regionID = "3", ID = "Traditional Dress", Images = "punjabiMenDress.jpeg", description = "Punjabi Mens Dress", largeDescription = "Punjabi men wear the straight cut Punjabi shalwar kameez, kurta and shalwar, dhoti, lungi or tehmat and kurta. Other Punjabi shalwar styles include the Pothohari shalwar, Multani shalwar, Dhoti shalwar and the Bahawalpuri shalwar which is very wide and baggy with many folds. Turban of a thin cloth is also worn especially in rural areas of Punjab where it is called pagri. Footwear include the khussa." };

            Punjab punjabDressesPic2 = new Punjab { regionID = "3", ID = "Traditional Dress", Images = "punjabiWomenDress.jpg", description = "Punjabi Mens Dress", largeDescription = "The Punjabi ghagra was the traditional apparel for women before the advent of the Punjabi suit. It is still worn in parts of the Punjab region and the outfit comprises the head scarf, kurta/kurti, suthan/salwar and the ghagra." };

            Punjab punjabDressesPic3 = new Punjab { regionID = "3", ID = "Traditional Dress", Images = "punjabiWomenDress1.jpg", description = "Punjabi Womens Dress", largeDescription = "The Punjabi ghagra was the traditional apparel for women before the advent of the Punjabi suit. It is still worn in parts of the Punjab region and the outfit comprises the head scarf, kurta/kurti, suthan/salwar and the ghagra." };



            Kpk kpkFestivalsPic1 = new Kpk { regionID = "4", ID = "Festivals", Images = "kpkAttanDance.jpg", description = "Attan Dance", largeDescription = "The performance of the attan dance has been a long customary in the Pashtun culture and is carried by Pashtuns mostly, and other ethnic groups as well.[ Attan is a special type of dance performed by a troupe of 50 to 100 dancers who wave red scarves in the air while musicians beat drums." };

            Kpk kpkFestivalsPic2 = new Kpk { regionID = "4", ID = "Festivals", Images = "kpkAttanDance1.jpg", description = "Attan Dance", largeDescription = "The performance of the attan dance has been a long customary in the Pashtun culture and is carried by Pashtuns mostly, and other ethnic groups as well.[ Attan is a special type of dance performed by a troupe of 50 to 100 dancers who wave red scarves in the air while musicians beat drums." };

            Kpk kpkFestivalsPic3 = new Kpk { regionID = "4", ID = "Festivals", Images = "kpkAttanDanceWomens.jpg", description = "Attan Dance", largeDescription = "The performance of the attan dance has been a long customary in the Pashtun culture and is carried by Pashtuns mostly, and other ethnic groups as well.[ Attan is a special type of dance performed by a troupe of 50 to 100 dancers who wave red scarves in the air while musicians beat drums." };


            Kpk kpkFoodPic1 = new Kpk { regionID = "4", ID = "Cuisine", Images = "kpkNihari.jpg", description = "Nihari", largeDescription = "Nihari  is a stew from the Province Khyber Pakhtunkhwa, consisting of slow-cooked meat mainly shank meat of camel or lamb and mutton, goat meat and chicken, along with bone marrow." };

            Kpk kpkFoodPic2 = new Kpk { regionID = "4", ID = "Cuisine", Images = "kpkChapliKabab.jpg", description = "Chappli Kabab", largeDescription = "Chapli kebab is a Mughlai-influenced Pashtun-style minced kebab, usually made from ground mutton or chicken with various spices in the shape of a patty. It originates from Peshawar, and is also known as the Peshawari kebab." };

            Kpk kpkFoodPic3 = new Kpk { regionID = "4", ID = "Cuisine", Images = "kpkKabuliPuloa.jpg", description = "Kabuli Puloa", largeDescription = "Kabuli palaw is made by cooking basmati or long grained rice in a brothy sauce (which makes the rice brown). This dish may be made with lamb, or chicken. Kabuli pulao is baked in the oven and may be topped with fried sliced carrots, raisins, orange peel strips, and chopped nuts like pistachios or almonds. The meat is covered by the rice or buried in the rice mixture." };

            Kpk kpkPlacesPic1 = new Kpk { regionID = "4", ID = "Places to visit", Images = "kpkKhyberPass.jpg", description = "Bab-e-Khyber", largeDescription = "The Khyber Pass became a critical part of the Silk Road, which connected Shanghai in the East to Cádiz on the coast of Spain. The Parthian and Roman Empires fought for control of passes such as these to gain access to the silk, jade, rhubarb, and other luxuries moving from China to Western Asia and Europe. Through the Khyber Pass, Gandhara (in present-day Pakistan) became a regional center of trade connecting Bagram in Afghanistan to Taxila in Pakistan, adding Indian luxury goods such as ivory, pepper, and textiles to the Silk Road commerce." };

            Kpk kpkPlacesPic2 = new Kpk { regionID = "4", ID = "Places to visit", Images = "kpkJheelSaifulMulook.jpg", description = "Jheel Saif-ul-Mulook", largeDescription = "he Lake Saif-ul-Mulook is named after a legendary prince. A fairy tale called Saif-ul-Muluk, written by the Sufi poet Mian Muhammad Bakhsh, talks of the lake.  It tells the story of the prince of Persia named Prince Saiful Malook who fell in love with a fairy princess named Princess Badri-ul-Jamala at the lake." };

            Kpk kpkPlacesPic3 = new Kpk { regionID = "4", ID = "Places to visit", Images = "kpkSawatValley.jpg", description = "Swat valley", largeDescription = "Swat valley lies in the lap of mountainous ranges, which are the offshoots of Hindukush, so the larger part of Swat is covered with high mountains and hills, the crests of which are hidden by everlasting snow. Though these gigantic ranges run irregularly: some to the west while the others to the east, but the general direction is North-South." };

            Kpk kpkDressesPic1 = new Kpk { regionID = "4", ID = "Traditional Dress", Images = "kpkWomenDress.jpg", description = "Pakhtun Womens Dress", largeDescription = "The traditional female dress is the Firaq partūg. Women typically wear solid-coloured trousers, a long kamīs shirt with a belt. Sometimes they will wear an encompassing burqa over this outfit or a tsādar on their head. " };

            Kpk kpkDressesPic2 = new Kpk { regionID = "4", ID = "Traditional Dress", Images = "kpkWomenDress1.jpg", description = "Pakhtun Womens Dress", largeDescription = "The traditional female dress is the Firaq partūg. Women typically wear solid-coloured trousers, a long kamīs shirt with a belt. Sometimes they will wear an encompassing burqa over this outfit or a tsādar on their head. " };

            Kpk kpkDressesPic3 = new Kpk { regionID = "4", ID = "Traditional Dress", Images = "kpkMensDress.jpg", description = "Pakhtun Mens Dress", largeDescription = "The traditional perahan worn in Khyber Pakhtunkhwa generally falls to the knees. The traditional perahan buttons on either shoulder, is collarless and is meant to be loose. Further, the traditional perahan is wide but fits closer to the body down to the waist and then is loose and full down to the knees (thereby flaring out). " };




            Gilgitbaltistan gilgitbaltistanFestivalsPic1 = new Gilgitbaltistan { regionID = "5", ID = "Festivals", Images = "gilgitSilkRoadFestival1.jpg", description = "Silk Route Festival", largeDescription = "Festival on the Roof of the world where natural environs, landscape, privileged location in the highest mountains of the world, breathtaking spectacles of sheer scenic beauty, wildlife and nature, awe-inspiring snow peaks, glittering glaciers, serene valleys of lush green foliage and fruits, gleaming and scintillating streams of unpolluted water, rich diversity of people, culture, folklore, arts, crafts and heritage," };

            Gilgitbaltistan gilgitbaltistanFestivalsPic2 = new Gilgitbaltistan { regionID = "5", ID = "Festivals", Images = "gilgitSilkRoadFestival2.jpg", description = "Silk Route Festival", largeDescription = "Festival on the Roof of the world where natural environs, landscape, privileged location in the highest mountains of the world, breathtaking spectacles of sheer scenic beauty, wildlife and nature, awe-inspiring snow peaks, glittering glaciers, serene valleys of lush green foliage and fruits, gleaming and scintillating streams of unpolluted water, rich diversity of people, culture, folklore, arts, crafts and heritage," };

            Gilgitbaltistan gilgitbaltistanFestivalsPic3 = new Gilgitbaltistan { regionID = "5", ID = "Festivals", Images = "gilgitSilkRoadFestival3.jpg", description = "Silk Route Festival", largeDescription = "Festival on the Roof of the world where natural environs, landscape, privileged location in the highest mountains of the world, breathtaking spectacles of sheer scenic beauty, wildlife and nature, awe-inspiring snow peaks, glittering glaciers, serene valleys of lush green foliage and fruits, gleaming and scintillating streams of unpolluted water, rich diversity of people, culture, folklore, arts, crafts and heritage," };

            Gilgitbaltistan gilgitbaltistanFoodPic1 = new Gilgitbaltistan { regionID = "5", ID = "Cuisine", Images = "gilgitGyal.jpg", description = "Gyal", largeDescription = "Gyal is a traditional local breakfast food, wheat pan-fried cakes with honey or fruit jam and the local favorite ingredient, apricot oil. The apricot oil creates such a sweet aroma to go with the smoky flavors from the charcoal or wood used in cooking. There are several different types of gyal, and the thing I love about this dish is how it is so simple and hearty, the perfect combination for a morning cup of buttery hot milk tea." };

            Gilgitbaltistan gilgitbaltistanFoodPic2 = new Gilgitbaltistan { regionID = "5", ID = "Cuisine", Images = "gilgitMamtu.jpg", description = "Mamtu", largeDescription = "Mamtu are little dumplings which are consumed as perfect starter or also served as party food. Mamtu are steam boiled dumplings filled with chopped  lamb, onions and a variety of vegetables. All the ingredients and meat are mixed together with spices and wrapped in dough. They are steamed for several hours in a steel container. The container has circular holes on it which allows the steam to be passed to the mamtus placed over the container. Mamtus are served hot with black pepper, vinegar or chili sauce." };

            Gilgitbaltistan gilgitbaltistanFoodPic3 = new Gilgitbaltistan { regionID = "5", ID = "Cuisine", Images = "gilgitApricot.jpg", description = "Apricot", largeDescription = "Gilgit-Baltistan is one of the most beautiful regions of Pakistan. Nature has gifted this region with immense beauty and blessings, including the highest peaks, lakes, and largest glaciers, rivers and variety of fruits. One of the most precious gifts by Allah is the blessing of delicious apricot, the major one among the variety of fruits in Gilgit Baltistan." };

            Gilgitbaltistan gilgitbaltistanPlacesPic1 = new Gilgitbaltistan { regionID = "5", ID = "Places to visit", Images = "gilgitAttabadLake.jpg", description = "Attabad Lake", largeDescription = "Attabad Lake  is a lake in Gojal Valley, Hunza, Gilgit Baltistan, region of Pakistan. The lake was created in January 2010 as a result of the Attabad Flood. Attabad Lake has become one of the biggest tourist attractions in Gilgit-Baltistan offering activities like boating, jet skiing, fishing and other recreational activities." };

            Gilgitbaltistan gilgitbaltistanPlacesPic2 = new Gilgitbaltistan { regionID = "5", ID = "Places to visit", Images = "gilgitOldSilkRoad.jpg", description = "Ancient Silk Road", largeDescription = "The highway, connecting the Gilgit–Baltistan region to the ancient Silk Road. Silk Road was an ancient network of trade routes that connected the East and West. It was central to cultural interaction between the regions for many centuries. The Silk Road primarily refers to the terrestrial routes connecting East Asia and Southeast Asia with East Africa, West Asia and Southern Europe." };

            Gilgitbaltistan gilgitbaltistanPlacesPic3 = new Gilgitbaltistan { regionID = "5", ID = "Places to visit", Images = "gilgitK2Mountain.jpg", description = "K2 Mountain", largeDescription = "K2 Mountain, also known as Mount Godwin Austen or Chhogori  at 8,611 metres (28,251 ft) above sea level, is the second highest mountain in the world, after Mount Everest at 8,848 metres (29,029 ft). It is located on the China–Pakistan border between Baltistan in the Gilgit-Baltistan region of northern Pakistan, and the Taxkorgan Tajik Autonomous County of Xinjiang, China.  K2 is the highest point of the Karakoram range and the highest point in both Pakistan and Xinjiang." };

            Gilgitbaltistan gilgitbaltistanDressesPic1 = new Gilgitbaltistan { regionID = "5", ID = "Traditional Dress", Images = "gilgitDress.jpg", description = "Gilgit-Baltistan Traditional Dress", largeDescription = "The people of Gilgit-Baltistan  customs of wearing caps are also common in Gilgit Baltistan women especially during events like bride makeup. Women usually wear: Iraghi cap, Loose shalwar kameez, and colorful frock." };

            Gilgitbaltistan gilgitbaltistanDressessPic2 = new Gilgitbaltistan { regionID = "5", ID = "Traditional Dress", Images = "gilgitMensDress.jpg", description = "Gilgit-Baltistan Traditional Dress", largeDescription = "Male members of Gilgit Baltistan wear different stuff of woollen caps they consider it as an honour for them. Men usually wear: woolen hat, Shalwar Kameer, and woolen rode having long or short sleeve." };

            Gilgitbaltistan gilgitbaltistanDressesPic3 = new Gilgitbaltistan { regionID = "5", ID = "Traditional Dress", Images = "gilgitWomenDress.jpg", description = "Gilgit-Baltistan Traditional Dress", largeDescription = "The most elegant part of the women dress of Gilgit Baltistan is the traditional cap. Various types of caps are used. The most popular cap is the beautiful embroidered Iraghi cap with the traditional piece of the jewel called silsila. Many other types of caps are used in various regions." };

            

           

            _sindhStorage = new List<Sindh> { sindhFestivalsPic1, sindhFestivalsPic2, sindhFestivalsPic3, sindhFoodPic1, sindhFoodPic2, sindhFoodPic3, sindhPlacesPic1, sindhPlacesPic2, sindhPlacesPic3, sindhDressesPic1, sindhDressesPic2, sindhDressesPic3 };

            _balochistanStorage = new List<Balochistan> { balochistanFestivalsPic1, balochistanFestivalsPic2, balochistanFestivalsPic3, balochistanFoodPic1, balochistanFoodPic2, balochistanFoodPic3, balochistanPlacesPic1, balochistanPlacesPic2, balochistanPlacesPic3, balochistanDressesPic1, balochistanDressesPic2, balochistanDressesPic3 };

            _punjabStorage = new List<Punjab> { punjabFestivalsPic1, punjabFestivalsPic2, punjabFestivalsPic3, punjabFoodPic1, punjabFoodPic2, punjabFoodPic3, punjabPlacesPic1, punjabPlacesPic2, punjabPlacesPic3, punjabDressesPic1, punjabDressesPic2, punjabDressesPic3 };

            _kpkStorage = new List<Kpk> { kpkFestivalsPic1, kpkFestivalsPic2, kpkFestivalsPic3, kpkFoodPic1, kpkFoodPic2, kpkFoodPic3, kpkPlacesPic1,kpkPlacesPic2, kpkPlacesPic3, kpkDressesPic1, kpkDressesPic2, kpkDressesPic3 };

            _gilgitbaltistanStorage = new List<Gilgitbaltistan> { gilgitbaltistanFestivalsPic1, gilgitbaltistanFestivalsPic2, gilgitbaltistanFestivalsPic3, gilgitbaltistanFoodPic1, gilgitbaltistanFoodPic2, gilgitbaltistanFoodPic3, gilgitbaltistanPlacesPic1, gilgitbaltistanPlacesPic2, gilgitbaltistanPlacesPic3, gilgitbaltistanDressesPic1, gilgitbaltistanDressessPic2, gilgitbaltistanDressesPic3 };





            StorageClass.StoreXML<List<Sindh>>("SindhDetail.xml", _sindhStorage);
            StorageClass.StoreXML<List<Balochistan>>("BalochistanDetail.xml", _balochistanStorage);
            StorageClass.StoreXML<List<Punjab>>("PunjabDetail.xml", _punjabStorage);
            StorageClass.StoreXML<List<Kpk>>("KpkDetail.xml", _kpkStorage);
            StorageClass.StoreXML<List<Gilgitbaltistan>>("GilgitbaltistanDetail.xml", _gilgitbaltistanStorage);


        }
    }
}
