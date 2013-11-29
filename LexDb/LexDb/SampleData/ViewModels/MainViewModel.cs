using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using LexDb.Resources;

namespace KeraTours.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            this.Items.Add(new ItemViewModel() { LineOne = "runtime one", LineTwo = "Maecenas praesent accumsan bibendum", LineThree = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime two", LineTwo = "Dictumst eleifend facilisi faucibus", LineThree = "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime three", LineTwo = "Habitant inceptos interdum lobortis", LineThree = "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime four", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime five", LineTwo = "Maecenas praesent accumsan bibendum", LineThree = "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime six", LineTwo = "Dictumst eleifend facilisi faucibus", LineThree = "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime seven", LineTwo = "Habitant inceptos interdum lobortis", LineThree = "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime eight", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime nine", LineTwo = "Maecenas praesent accumsan bibendum", LineThree = "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime ten", LineTwo = "Dictumst eleifend facilisi faucibus", LineThree = "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime eleven", LineTwo = "Habitant inceptos interdum lobortis", LineThree = "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime twelve", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime thirteen", LineTwo = "Maecenas praesent accumsan bibendum", LineThree = "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime fourteen", LineTwo = "Dictumst eleifend facilisi faucibus", LineThree = "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime fifteen", LineTwo = "Habitant inceptos interdum lobortis", LineThree = "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat" });
            this.Items.Add(new ItemViewModel() { LineOne = "runtime sixteen", LineTwo = "Nascetur pharetra placerat pulvinar", LineThree = "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum" });



            this.Items.Add(new ItemViewModel() {Kerala = "With the Arabian Sea in the west, the Western Ghats towering 500-2700 m in the east and networked by 44 rivers, Kerala enjoys unique geographical features that have made it one of the most sought after tourist destinations in Asia. An equable climate. A long shoreline with serene beaches. Tranquil stretches of emerald backwaters. Lush hill stations and exotic wildlife. Waterfalls. Sprawling plantations and paddy fields. Ayurvedic health holidays. Enchanting art forms. Magical festivals. Historic and cultural monuments. An exotic cuisine... All of which offer you a unique experience. And what's more, each of these charming destinations is only a two hour drive from the other - a singular advantage no other destination offers.\n\n"});
            this.Items.Add(new ItemViewModel() {Kerala = "Kerala, India's most advanced society: With hundred percent literacy. World-class health care systems. India's lowest infant mortality and highest life expectancy rates. The highest physical quality of life in India. Peaceful and pristine, Kerala is India's cleanest state.\n\n"});
            this.Items.Add(new ItemViewModel() {Kerala = "For administrative purpose, the state of Kerala is divided into fourteen districts. Most of these districts offer all the tourism products typical of the State."});

            
            this.Items.Add(new ItemViewModel() { Alapuzha = "Referred to as the Venice of the East, Alappuzha has always enjoyed an important place in the maritime history of Kerala. Today, it is famous for its boat races, backwater holidays, beaches, marine products and coir industry. Alappuzha beach is a popular picnic spot. The pier, which extends into the sea here, is over 137 years old. Entertainment facilities at the Vijaya Beach Park add to the attraction of the beach. There is also an old lighthouse nearby which is greatly fascinating to visitors.\n\n Another delightful experience while in Alappuzha is a houseboat cruise. The ones you find in the backwaters of Alappuzha are in fact reworked version of Kettuvallams of olden times. The original Kettuvallams or rice barges used to carry tons of rice and spices. The Kettuvallam or 'boat with knots' was so called because the entire boat was held together with coir knots only.\n\n Of late, houseboats come with all creature comforts of a good hotel including furnished bedrooms, modern toilets, cozy living rooms, a kitchen and even a balcony for angling. And one can always enjoy uninterrupted views of backwater life while staying in a houseboat." });

            this.Items.Add(new ItemViewModel() { Bekal = "Kasaragod, the Northern most district of Kerala is renowned as the land of gods, forts, rivers, hills and beautiful beaches. The imposing fort at Bekal is one of the largest and best preserved forts in Kerala. The beautiful expanse of the shallow beach near the Bekal fort known as Bekal Fort Beach has been developed as an exotic beach location by the Bekal Resorts Development Corporation (BRDC).\n\n Beautification: Beautification of the site includes installation of two sculptures of Theyyam created using laterite on the beach and a shed the walls of which are adorned with murals created by artisans from Nilambur. Apart from these a rock garden at the parking area has been developed where laterite boulders of various sizes have been utilised. Under the social forestry scheme, trees have been planted in the beach area.\n\n Parking facilities: The BRDC has developed about 7000 sq. m of land for parking different types of vehicles.\n\n Walkway: A beautiful walkway has been laid for the visiting tourists to explore the beauty of the fine coastline and enjoy the panoramic view of the Bekal Fort.\n\n Illuminated beach: The beach gets illuminated during the evening hours so that tourists can spend more time at the beach even after the sun sets.\n\n Resting facilities: Multi shed and Eru madam (Tree house) would provide the tourists enough facilities to take rest and enjoy the sea breeze. By using locally available materials seating arrangements have been provided for the tourists at the beach.\n\n Toilets: Toilets have been provided for the use of tourists and eco-friendly bamboo waste bins have been provided in the entire beach site for keeping the area clean.\n\n Children's park: A park has been developed here for children below 14 years.\n\n In order to maintain the developed site a nominal charge of one rupee from each visitor would be collected as entry fees. A similar nominal vehicle parking fees would also be collected. The BRDC also aims to develop in future another 11 acres of land at the beach for constructing water park, theme park etc.\n\n The BRDC was set up by the Government of Kerala to develop Bekal as a planned eco-friendly destination. The BRDC has utilised 19 acres of land for the development of the Bekal Fort Beach at a cost of approximately Rs. 25 million including land acquisition charges." });

            this.Items.Add(new ItemViewModel() { Fort = "To explore the historic town of Fort Kochi, there is no better choice than setting out on foot. Relax, breathe deep and come out in cotton dresses, soft shoes and yes - a straw hat. At each and every nook of this island steeped in history, there is something amusing awaiting you. It is a world of its own, retaining the specimens of a bygone era and still proud of those days. If you can smell the past, nothing can stop you from walking through these streets.\n\n Walking straight through the K. J. Herschel Road and turning left, you can have a glimpse of Fort Immanuel. This bastion once belonged to the Portuguese and is a symbol of the strategic alliance which existed between the Maharaja of Cochin and the Monarch of Portugal, after whom the fort is named. This fort was built in 1503 and reinforced in 1538. Walking a bit further, you come across the Dutch cemetery. Consecrated in 1724 and managed by the Church of South India, the tomb stones here silently remind visitors of those Europeans who left their homeland to expand their colonial empires.\n\n The next spot to watch is the ancient Thakur House, which stands erect as a concrete specimen of the colonial era. The building is simply graceful. Formerly known as Kunal or Hill Bungalow, it was home to the managers of the National Bank of India during the British rule. Now, it belongs to the Thakur and Company, renowned tea trading firm.\n\n Walk on and there is another colonial structure awaiting you - David Hall. It was built around 1695 by the Dutch East India Company. The hall is associated with Hendrik Adriaan van Reed tot Drakeston, renowned Dutch commander, who is more admired for his monumental book on the flora of Kerala namely Hortus Malabaricus. However, David Hall is named after David Koder, a later occupant of the hall.\n\n Walking past the Parade Ground, the four acres of ground where the Portuguese, the Dutch and the British had once conducted military parades, you reach the St. Francis Church, the oldest European church in India. It has passed through many phases ever since the Portuguese built it in 1503. Now the church is under the Church of South India. By the way, it was in this church that Vasco-da Gama had been buried and his tombstone can still be seen.\n\n The Church Road is a nice place to walk, with the cool breeze from the Arabian Sea caressing your body. Walk down a bit closer to the sea and there is the Cochin Club, home to an impressive library and collection of sporting trophies. Set in a beautifully landscaped park, the club still retains its British ambience." });

            this.Items.Add(new ItemViewModel() { Kumarakom = "The village of Kumarakom is a cluster of little islands on the Vembanad Lake, and is part of the Kuttanad region. The bird sanctuary here, which is spread across 14 acres is a favourite haunt of migratory birds and an ornithologist's paradise. Egrets, darters, herons, teals, waterfowls, cuckoo, wild duck and migratory birds like the Siberian Stork visit here in flocks and are a fascinate the visitors.\n\n An enchanting backwater destination, Kumarakom offers visitors many other leisure options. Boating and fishing facilities are available at the Taj Garden Retreat, a sprawling old bungalow-turned-resort.\n\n Waterscapes, the backwater resort of the Kerala Tourism Development Corporation has independent cottages built on stilts, set amidst coconut groves and panoramic view of the backwaters. Holiday packages involving houseboats, traditional Kettuvalloms (rice barges) offer great experiences." });

            this.Items.Add(new ItemViewModel() { Munnar = "It is one of the attractions that contributed to Kerala's popularity as a travel destination among domestic and foreign travellers. Situated at the confluence of three mountain streams - Muthirapuzha, Nallathanni and Kundala, and perched about 1600 m above sea level, the hill station of Munnar once used to be the summer resort of the erstwhile British administration in south India.\n\n This hill station is marked by vast expanses of tea plantations, colonial bungalows, rivulets, waterfalls and cool weather. It is also an ideal destination for trekking and mountain biking.\n\n Let us now explore some of the options in and around Munnar that would provide travellers ample opportunities to enjoy the captivating hill station of Munnar.\n\nEravikulam National Park\n\n One of the main attractions near Munnar is the Eravikulam National Park. Located about 15 km from Munnar, this park is famous for its endangered inhabitant - the Nilgiri Tahr. Spread over an area of 97 sq. km., this park is also home to several species of rare butterflies, animals and birds. A great place for trekking, the park offers a magnificent view of the tea plantations and also the rolling hills caressed by blankets of mists. The park becomes a hot destination when the hill slopes here get covered in a carpet of blue, resulting from the flowering of Neelakurinji. It is a plant endemic to this part of the Western Ghats which blooms once in twelve years. The last time it bloomed was in 2006.\n\nAnamudi Peak\n\n Located inside the Eravikulam National Park is the Anamudi Peak. This is the highest peak in south India standing at a height of over 2700 m. Treks to the peak are allowed with permission from the Forest and Wildlife authorities at Eravikulam.\n\nMattupetty\n\n Another place of interest, located about 13 km from Munnar Town, is Mattupetty. Situated at a height of 1700 m above sea level, Mattupetty is known for its storage masonry dam and the beautiful lake, which offers pleasurable boat rides, enabling one to enjoy the surrounding hills and landscape. Mattupetty's fame is also attributed to the dairy farm run by the Indo-Swiss Livestock Project, where one would come across different high yielding breeds of cows. Mattupetty with its lush green tea plantations, rolling grasslands and the Shola forests is also ideal for trekking and is home to a variety of birds.\n\nPallivasal\n\n Pallivasal, located at about 3 km from Chithirapuram in Munnar is the venue of the first Hydro-electric project in Kerala. It is a place of immense scenic beauty and is often favoured by visitors as a picnic spot." });

            this.Items.Add(new ItemViewModel() { Thekkady = "Altitude: 900-1800 m above sea level\n\n Rainfall: 2500 mm\n\n The very sound of the word Thekkady conjures up images of elephants, unending chains of hills and spice scented plantations. The Periyar forests of Thekkady is one of the finest wildlife reserves in India. Spread across the entire district are picturesque plantations and hill towns that hold great opportunities for treks and mountain walks.\n\nFlora\n Over 1965 flowering plants including 171 grass species 143 species of orchids. The only south Indian conifer Podocarpus wallichianus grows in the forests of Periyar Tiger Reserve.\n\nFauna\n Mammals: Thirty five species which include the Asian elephant, Tiger, Indian bison, sambar deer, Indian wild dog, Leopard, Barking deer, Smooth-coated otter which can be sighted during a boat cruise in the Periyar Lake. The Nilgiri tahr is confined to the higher rocky areas whereas the endangered lion tailed macaque can be found in the interior evergreen forests. Both the bonnet macaques and Nilgiri langur can be seen foraging from the trees near the boat landing. Malabar giant squirrel is omnipresent.\nBirds: 265 species including migrants. The Malabar grey hornbill, The Indian pied hornbill, Whitebellied Treepie, many species of drongos, woodpeckers, flycatchers, babblers, the spectacular Malabar trogon, etc can be seen near the boat landing.\nReptiles: Cobra, viper, krait, a number of non-poisonous snakes, and the Indian monitor lizard.\nAmphibians: Frogs like the colorful Malabar gliding frog, fungoid frog, bicolored frog, many species of toads, and limbless caecilians.\nPisces (fish): The Periyar lake and streams have several species of fish including the masheer, the famous and endangered game fish of India. The Smooth-coated otter can be frequently spotted from the boat.\nPlantations: Tea, cardamom, pepper and coffee plantations abound in the areas adjoining the Tiger Reserve.\nWatch Towers: There are a few watch towers inside Periyar Tiger Reserve which are excellent for viewing wildlife. Reservations can be made at the Forest Information Centre, Thekkady. Ph: 322028.\nPermitting authority: The Wildlife Preservation Officer, Periyar Tiger Reserve, Thekkady." });

            this.Items.Add(new ItemViewModel() { Wayanad = "Area: 2132 sq. km\n\nAltitude: 700 - 2100 m above sea level\n\n A bio-diverse region spread across 2,132 square kilometers on the lofty Western Ghats, Wayanad is one of the few districts in Kerala that has been able to retain its pristine nature. Hidden away in the hills of this land are some of the oldest tribes, as yet untouched by civilization. And the very first prehistoric engravings in Kerala discovered in the foothills of Edakkal and around Ambukuthimala bear testimony to a pre-historic culture dating back to the Mesolithic Age. Strikingly scenic, it is known for its sub-tropical savannahs, picturesque hill stations, sprawling spice plantations, luxuriant forests and rich cultural traditions. A holistic confluence of wilderness, history and culture, Wayanad is located on the southern tip of the magnificent Deccan plateau.\n\nMUST SEE\n Chembra Peak\n Kuruvadweep\n Vythiri Hill Station\n Banasura Sagar Dam\n Edakkal Caves" });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}