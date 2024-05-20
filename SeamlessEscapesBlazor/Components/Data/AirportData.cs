﻿using System.Collections.Generic;
using static SeamlessEscapesBlazor.Components.Pages.Home;

namespace SeamlessEscapesBlazor.Data // Replace YourNamespace with your actual namespace
{
    public static class AirportData
    {
        public static List<AirportInfo> GetAirports()
        {
            return new List<AirportInfo>
            {
                new AirportInfo { Code = "ABQ", Name = "Albuquerque International" },
                new AirportInfo { Code = "ANC", Name = "Ted Stevens Anchorage International" },
                new AirportInfo { Code = "ATL", Name = "William B Hartsfield-Atlanta Intl" },
                new AirportInfo { Code = "AUS", Name = "Austin-Bergstrom International" },
                new AirportInfo { Code = "BDL", Name = "Bradley International" },
                new AirportInfo { Code = "BHM", Name = "Birmingham International" },
                new AirportInfo { Code = "BNA", Name = "Nashville International" },
                new AirportInfo { Code = "BOS", Name = "Gen Edw L Logan Intl" },
                new AirportInfo { Code = "BUF", Name = "Buffalo Niagara Intl" },
                new AirportInfo { Code = "BUR", Name = "Burbank-Glendale-Pasadena" },
                new AirportInfo { Code = "BWI", Name = "Baltimore-Washington International" },
                new AirportInfo { Code = "CHS", Name = "Charleston AFB International" },
                new AirportInfo { Code = "CLE", Name = "Cleveland-Hopkins Intl" },
                new AirportInfo { Code = "CLT", Name = "Charlotte Douglas International" },
                new AirportInfo { Code = "CMH", Name = "Port Columbus Intl" },
                new AirportInfo { Code = "CVG", Name = "Cincinnati Northern Kentucky Intl" },
                new AirportInfo { Code = "DAL", Name = "Dallas Love" },
                new AirportInfo { Code = "DCA", Name = "Ronald Reagan Washington National" },
                new AirportInfo { Code = "DEN", Name = "Denver Intl" },
                new AirportInfo { Code = "DFW", Name = "Dallas-Fort Worth International" },
                new AirportInfo { Code = "DTW", Name = "Detroit Metropolitan-Wayne County" },
                new AirportInfo { Code = "ELP", Name = "El Paso International" },
                new AirportInfo { Code = "EWR", Name = "Newark Intl" },
                new AirportInfo { Code = "FLL", Name = "Fort Lauderdale-Hollywood Int'l" },
                new AirportInfo { Code = "HNL", Name = "Honolulu International" },
                new AirportInfo { Code = "HOU", Name = "William P X" },
                new AirportInfo { Code = "IAD", Name = "Washington Dulles International" },
                new AirportInfo { Code = "IAH", Name = "George Bush Intercontinental" },
                new AirportInfo { Code = "IND", Name = "Indianapolis International" },
                new AirportInfo { Code = "JAX", Name = "Jacksonville International" },
                new AirportInfo { Code = "JFK", Name = "John F Kennedy Intl" },
                new AirportInfo { Code = "LAS", Name = "McCarran International" },
                new AirportInfo { Code = "LAX", Name = "Los Angeles International" },
                new AirportInfo { Code = "LGA", Name = "LaGuardia" },
                new AirportInfo { Code = "LIT", Name = "Adams" },
                new AirportInfo { Code = "MCI", Name = "Kansas City International" },
                new AirportInfo { Code = "MCO", Name = "Orlando International" },
                new AirportInfo { Code = "MDW", Name = "Chicago Midway" },
                new AirportInfo { Code = "MEM", Name = "Memphis International" },
                new AirportInfo { Code = "MIA", Name = "Miami International" },
                new AirportInfo { Code = "MKE", Name = "General Mitchell International" },
                new AirportInfo { Code = "MSP", Name = "Minneapolis-St Paul Intl" },
                new AirportInfo { Code = "MSY", Name = "New Orleans International" },
                new AirportInfo { Code = "OAK", Name = "Metropolitan Oakland International" },
                new AirportInfo { Code = "OGG", Name = "Kahului" },
                new AirportInfo { Code = "OKC", Name = "Will Rogers World" },
                new AirportInfo { Code = "OMA", Name = "Eppley Airfield" },
                new AirportInfo { Code = "ONT", Name = "Ontario International" },
                new AirportInfo { Code = "ORD", Name = "Chicago O'Hare International" },
                new AirportInfo { Code = "ORF", Name = "Norfolk International" },
                new AirportInfo { Code = "PBI", Name = "Palm Beach International" },
                new AirportInfo { Code = "PDX", Name = "Portland Intl" },
                new AirportInfo { Code = "PHL", Name = "Philadelphia Intl" },
                new AirportInfo { Code = "PHX", Name = "Phoenix Sky Harbor International" },
                new AirportInfo { Code = "PIT", Name = "Pittsburgh International" },
                new AirportInfo { Code = "PVD", Name = "Theodore F Green State" },
                new AirportInfo { Code = "RDU", Name = "Raleigh-Durham International" },
                new AirportInfo { Code = "RIC", Name = "Richmond International" },
                new AirportInfo { Code = "RNO", Name = "Reno Tahoe International" },
                new AirportInfo { Code = "RSW", Name = "Southwest Florida International" },
                new AirportInfo { Code = "SAN", Name = "San Diego International-Lindbergh" },
                new AirportInfo { Code = "SAT", Name = "San Antonio International" },
                new AirportInfo { Code = "SDF", Name = "Louisville International-Standiford" },
                new AirportInfo { Code = "SEA", Name = "Seattle-Tacoma Intl" },
                new AirportInfo { Code = "SFO", Name = "San Francisco International" },
                new AirportInfo { Code = "SJC", Name = "San Jose International" },
                new AirportInfo { Code = "SJU", Name = "Luis Munoz Marin International" },
                new AirportInfo { Code = "SLC", Name = "Salt Lake City Intl" },
                new AirportInfo { Code = "SMF", Name = "Sacramento International" },
                new AirportInfo { Code = "SNA", Name = "John Wayne Orange Co" },
                new AirportInfo { Code = "STL", Name = "Lambert-St Louis International" },
                new AirportInfo { Code = "TPA", Name = "Tampa International" },
                new AirportInfo { Code = "TUL", Name = "Tulsa International" },
                new AirportInfo { Code = "TUS", Name = "Tucson International" },
                new AirportInfo { Code = "ABE", Name = "Lehigh Valley International" },
                new AirportInfo { Code = "ABI", Name = "Abilene Regional" },
                new AirportInfo { Code = "ABR", Name = "Aberdeen Regional" },
                new AirportInfo { Code = "ABY", Name = "Southwest Georgia Regional" },
                new AirportInfo { Code = "ACK", Name = "Nantucket Memorial" },
                new AirportInfo { Code = "ACT", Name = "Waco Regional" },
                new AirportInfo { Code = "ACY", Name = "Atlantic City International" },
                new AirportInfo { Code = "ADK", Name = "Adak" },
                new AirportInfo { Code = "ADQ", Name = "Kodiak" },
                new AirportInfo { Code = "AEX", Name = "Alexandria International" },
                new AirportInfo { Code = "AGS", Name = "Bush" },
                new AirportInfo { Code = "AKN", Name = "King Salmon" },
                new AirportInfo { Code = "ALB", Name = "Albany Cty" },
                new AirportInfo { Code = "ALO", Name = "Waterloo Municipal" },
                new AirportInfo { Code = "AMA", Name = "Amarillo International" },
                new AirportInfo { Code = "APN", Name = "Alpena County Regional" },
                new AirportInfo { Code = "ART", Name = "Watertown Intl" },
                new AirportInfo { Code = "ASE", Name = "Aspen-Pitkin Co Sardy" },
                new AirportInfo { Code = "ATW", Name = "Outagamie County Regional" },
                new AirportInfo { Code = "AVL", Name = "Asheville Regional" },
                new AirportInfo { Code = "AVP", Name = "Wilkes-Barre Scranton Intl" },
                new AirportInfo { Code = "AZO", Name = "Kalamazoo County" },
                new AirportInfo { Code = "BET", Name = "Bethel" },
                new AirportInfo { Code = "BFL", Name = "Meadows" },
                new AirportInfo { Code = "BGM", Name = "Binghamton Regional" },
                new AirportInfo { Code = "BGR", Name = "Bangor International" },
                new AirportInfo { Code = "BIL", Name = "Billings Logan Intl" },
                new AirportInfo { Code = "BIS", Name = "Bismarck Municipal" },
                new AirportInfo { Code = "BJI", Name = "Bemidji-Beltrami County" },
                new AirportInfo { Code = "BLI", Name = "Bellingham Intl" },
                new AirportInfo { Code = "BMI", Name = "Central Illinois Regional" },
                new AirportInfo { Code = "BOI", Name = "Boise Air Terminal" },
                new AirportInfo { Code = "BPT", Name = "Southeast Texas Regional" },
                new AirportInfo { Code = "BQK", Name = "Glynco Jetport" },
                new AirportInfo { Code = "BQN", Name = "Rafael Hernandez" },
                new AirportInfo { Code = "BRD", Name = "Brainerd-Crow Wing County Regional" },
                new AirportInfo { Code = "BRO", Name = "Brownsville S.Padre Island International" },
                new AirportInfo { Code = "BRW", Name = "Wiley Post Will Rogers Memorial" },
                new AirportInfo { Code = "BTM", Name = "Bert Mooney" },
                new AirportInfo { Code = "BTR", Name = "Baton Rouge Metropolitan" },
                new AirportInfo { Code = "BTV", Name = "Burlington International" },
                new AirportInfo { Code = "BZN", Name = "Gallatin" },
                new AirportInfo { Code = "CAE", Name = "Columbia Metropolitan" },
                new AirportInfo { Code = "CAK", Name = "Akron-Canton Regional" },
                new AirportInfo { Code = "CDC", Name = "Cedar City Muni" },
                new AirportInfo { Code = "CDV", Name = "Merle K (Mudhole) Smith" },
                new AirportInfo { Code = "CEC", Name = "Jack McNamara" },
                new AirportInfo { Code = "CHA", Name = "Lovell" },
                new AirportInfo { Code = "CHO", Name = "Charlottesville-Albermarle" },
                new AirportInfo { Code = "CIC", Name = "Chico Municipal" },
                new AirportInfo { Code = "CID", Name = "Eastern Iowa" },
                new AirportInfo { Code = "CIU", Name = "Chippewa County International" },
                new AirportInfo { Code = "CLD", Name = "MC Clellan-Palomar Airport" },
                new AirportInfo { Code = "CLL", Name = "Easterwood" },
                new AirportInfo { Code = "CMI", Name = "University of Illinois-Willard" },
                new AirportInfo { Code = "CMX", Name = "Houghton County Memorial" },
                new AirportInfo { Code = "CNY", Name = "Canyonlands" },
                new AirportInfo { Code = "COD", Name = "Yellowstone Regional" },
                new AirportInfo { Code = "COS", Name = "City of Colorado Springs Muni" },
                new AirportInfo { Code = "COU", Name = "Columbia Regional" },
                new AirportInfo { Code = "CPR", Name = "Natrona County Intl" },
                new AirportInfo { Code = "CRP", Name = "Corpus Christi International" },
                new AirportInfo { Code = "CRW", Name = "Yeager" },
                new AirportInfo { Code = "CSG", Name = "Columbus Metropolitan" },
                new AirportInfo { Code = "CWA", Name = "Central Wisconsin" },
                new AirportInfo { Code = "CYS", Name = "Cheyenne" },
                new AirportInfo { Code = "DAB", Name = "Daytona Beach International" },
                new AirportInfo { Code = "DAY", Name = "James M Cox Dayton Intl" },
                new AirportInfo { Code = "DBQ", Name = "Dubuque Municipal" },
                new AirportInfo { Code = "DHN", Name = "Dothan" },
                new AirportInfo { Code = "DIK", Name = "Dickinson Municipal" },
                new AirportInfo { Code = "DLG", Name = "Dillingham" },
                new AirportInfo { Code = "DLH", Name = "Duluth International" },
                new AirportInfo { Code = "DRO", Name = "Durango-La Plata County" },
                new AirportInfo { Code = "DRT", Name = "Del Rio International" },
                new AirportInfo { Code = "DSM", Name = "Des Moines International" },
                new AirportInfo { Code = "DVL", Name = "Devils Lake Municipal-Knoke" },
                new AirportInfo { Code = "EAU", Name = "Chippewa Valley Regional" },
                new AirportInfo { Code = "EGE", Name = "Eagle County Regional" },
                new AirportInfo { Code = "EKO", Name = "Elko Regional" },
                new AirportInfo { Code = "ELM", Name = "Elmira Corning Regional" },
                new AirportInfo { Code = "ERI", Name = "Erie Intl" },
                new AirportInfo { Code = "ESC", Name = "Delta County" },
                new AirportInfo { Code = "EUG", Name = "Mahlon Sweet" },
                new AirportInfo { Code = "EVV", Name = "Evansville Regional" },
                new AirportInfo { Code = "EWN", Name = "Craven County Regional" },
                new AirportInfo { Code = "EYW", Name = "Key West International" },
                new AirportInfo { Code = "FAI", Name = "Fairbanks International" },
                new AirportInfo { Code = "FAR", Name = "Hector International" },
                new AirportInfo { Code = "FAT", Name = "Fresno Yosemite International" },
                new AirportInfo { Code = "FAY", Name = "Fayetteville Municipal" },
                new AirportInfo { Code = "FCA", Name = "Glacier Park Intl" },
                new AirportInfo { Code = "FLG", Name = "Flagstaff Pulliam" },
                new AirportInfo { Code = "FLO", Name = "Florence Regional" },
                new AirportInfo { Code = "FNT", Name = "Bishop" },
                new AirportInfo { Code = "FOE", Name = "Forbes" },
                new AirportInfo { Code = "FSD", Name = "Joe Foss" },
                new AirportInfo { Code = "FSM", Name = "Fort Smith Regional" },
                new AirportInfo { Code = "FWA", Name = "Fort Wayne International" },
                new AirportInfo { Code = "GCC", Name = "Gillette-Campbell County" },
                new AirportInfo { Code = "GCK", Name = "Garden City Regional" },
                new AirportInfo { Code = "GEG", Name = "Spokane Intl" },
                new AirportInfo { Code = "GGG", Name = "Gregg County" },
                new AirportInfo { Code = "GJT", Name = "Walker" },
                new AirportInfo { Code = "GNV", Name = "Gainesville Regional" },
                new AirportInfo { Code = "GPT", Name = "Gulfport-Biloxi Regional" },
                new AirportInfo { Code = "GRB", Name = "Austin Straubel International" },
                new AirportInfo { Code = "GRI", Name = "Central Nebraska Regional" },
                new AirportInfo { Code = "GRK", Name = "Robert Gray AAF" },
                new AirportInfo { Code = "GRR", Name = "Kent County International" },
                new AirportInfo { Code = "GSO", Name = "Piedmont Triad International" },
                new AirportInfo { Code = "GSP", Name = "Greenville-Spartanburg" },
                new AirportInfo { Code = "GST", Name = "Gustavus" },
                new AirportInfo { Code = "GTF", Name = "Great Falls Intl" },
                new AirportInfo { Code = "GTR", Name = "Golden Triangle Regional" },
                new AirportInfo { Code = "GUC", Name = "Gunnison County" },
                new AirportInfo { Code = "GUM", Name = "Guam International" },
                new AirportInfo { Code = "HDN", Name = "Yampa Valley" },
                new AirportInfo { Code = "HIB", Name = "Chisholm-Hibbing" },
                new AirportInfo { Code = "HLN", Name = "Helena Regional" },
                new AirportInfo { Code = "HOB", Name = "Lea County Regional" },
                new AirportInfo { Code = "HPN", Name = "Westchester Cty" },
                new AirportInfo { Code = "HRL", Name = "Valley International" },
                new AirportInfo { Code = "HSV", Name = "Huntsville International" },
                new AirportInfo { Code = "HTS", Name = "Tri-State Walker-Long" },
                new AirportInfo { Code = "HYA", Name = "Barnstable Mun Boardman Polando" },
                new AirportInfo { Code = "HYS", Name = "Hays Municipal" },
                new AirportInfo { Code = "ICT", Name = "Wichita Mid-Continent" },
                new AirportInfo { Code = "IDA", Name = "Idaho Falls Regional" },
                new AirportInfo { Code = "ILG", Name = "New Castle County" },
                new AirportInfo { Code = "ILM", Name = "Wilmington International" },
                new AirportInfo { Code = "IMT", Name = "Ford" },
                new AirportInfo { Code = "INL", Name = "Falls International" },
                new AirportInfo { Code = "IPL", Name = "Imperial County" },
                new AirportInfo { Code = "ISN", Name = "Sloulin Field International" },
                new AirportInfo { Code = "ISP", Name = "Long Island - MacArthur" },
                new AirportInfo { Code = "ITH", Name = "Tompkins Cty" },
                new AirportInfo { Code = "ITO", Name = "Hilo International" },
                new AirportInfo { Code = "IYK", Name = "Inyokern" },
                new AirportInfo { Code = "JAC", Name = "Jackson Hole" },
                new AirportInfo { Code = "JAN", Name = "Jackson International" },
                new AirportInfo { Code = "JLN", Name = "Joplin Regional" },
                new AirportInfo { Code = "JMS", Name = "Jamestown Municipal" },
                new AirportInfo { Code = "JNU", Name = "Juneau International" },
                new AirportInfo { Code = "KOA", Name = "Kona International At Keahole" },
                new AirportInfo { Code = "KTN", Name = "Ketchikan International" },
                new AirportInfo { Code = "LAN", Name = "Capital City" },
                new AirportInfo { Code = "LAR", Name = "Laramie Regional" },
                new AirportInfo { Code = "LAW", Name = "Lawton-Ft Sill Regional" },
                new AirportInfo { Code = "LBB", Name = "Lubbock International" },
                new AirportInfo { Code = "LCH", Name = "Lake Charles Regional" },
                new AirportInfo { Code = "LEX", Name = "Blue Grass" },
                new AirportInfo { Code = "LFT", Name = "Lafayette Regional" },
                new AirportInfo { Code = "LGB", Name = "Long Beach (Daugherty)" },
                new AirportInfo { Code = "LIH", Name = "Lihue" },
                new AirportInfo { Code = "LMT", Name = "Klamath Falls International" },
                new AirportInfo { Code = "LNK", Name = "Lincoln Municipal" },
                new AirportInfo { Code = "LRD", Name = "Laredo International" },
                new AirportInfo { Code = "LSE", Name = "La Crosse Municipal" },
                new AirportInfo { Code = "LWB", Name = "Greenbrier Valley" },
                new AirportInfo { Code = "LWS", Name = "Lewiston-Nez Perce County" },
                new AirportInfo { Code = "LYH", Name = "Lynchburg Municipal-Preston Glenn" },
                new AirportInfo { Code = "MAF", Name = "Midland International" },
                new AirportInfo { Code = "MBS", Name = "Mbs International" },
                new AirportInfo { Code = "MCN", Name = "Middle Georgia Regional" },
                new AirportInfo { Code = "MDT", Name = "Harrisburg Intl" },
                new AirportInfo { Code = "MEI", Name = "Key" },
                new AirportInfo { Code = "MFE", Name = "McAllen Miller International" },
                new AirportInfo { Code = "MFR", Name = "Rogue Valley International" },
                new AirportInfo { Code = "MGM", Name = "Montgomery Regional Apt" },
                new AirportInfo { Code = "MHK", Name = "Manhattan Regional" },
                new AirportInfo { Code = "MHT", Name = "Manchester" },
                new AirportInfo { Code = "MKG", Name = "Muskegon County" },
                new AirportInfo { Code = "MLB", Name = "Melbourne International" },
                new AirportInfo { Code = "MLI", Name = "Quad City" },
                new AirportInfo { Code = "MLU", Name = "Monroe Regional" },
                new AirportInfo { Code = "MMH", Name = "Mammoth Yosemite" },
                new AirportInfo { Code = "MOB", Name = "Mobile Regional" },
                new AirportInfo { Code = "MOD", Name = "Modesto City-County-Harry Sham" },
                new AirportInfo { Code = "MOT", Name = "Minot International" },
                new AirportInfo { Code = "MQT", Name = "Marquette County Airport" },
                new AirportInfo { Code = "MRY", Name = "Monterey Peninsula" },
                new AirportInfo { Code = "MSN", Name = "Dane County Regional" },
                new AirportInfo { Code = "MSO", Name = "Missoula International" },
                new AirportInfo { Code = "MTJ", Name = "Montrose Regional" },
                new AirportInfo { Code = "MVY", Name = "Marthas Vineyard" },
                new AirportInfo { Code = "MWH", Name = "Grant County" },
                new AirportInfo { Code = "MYR", Name = "Myrtle Beach International" },
                new AirportInfo { Code = "OAJ", Name = "Albert J Ellis" },
                new AirportInfo { Code = "OME", Name = "Nome" },
                new AirportInfo { Code = "ORH", Name = "Worcester Regional" },
                new AirportInfo { Code = "OTH", Name = "North Bend Muni" },
                new AirportInfo { Code = "OTZ", Name = "Ralph Wien Memorial" },
                new AirportInfo { Code = "OXR", Name = "Oxnard" },
                new AirportInfo { Code = "PAH", Name = "Barkley Regional" },
                new AirportInfo { Code = "PFN", Name = "Panama City-Bay County International" },
                new AirportInfo { Code = "PHF", Name = "Newport News Williamsburg International" },
                new AirportInfo { Code = "PIA", Name = "Greater Peoria Regional" },
                new AirportInfo { Code = "PIB", Name = "Hattiesburg-Laurel Regional" },
                new AirportInfo { Code = "PIE", Name = "St. Petersburg-Clearwater International" },
                new AirportInfo { Code = "PIH", Name = "Pocatello Regional" },
                new AirportInfo { Code = "PIR", Name = "Pierre Regional" },
                new AirportInfo { Code = "PLN", Name = "Pellston Regional  of Emmet County" },
                new AirportInfo { Code = "PNS", Name = "Pensacola Regional" },
                new AirportInfo { Code = "PPG", Name = "Pago Pago International" },
                new AirportInfo { Code = "PSC", Name = "Tri-Cities" },
                new AirportInfo { Code = "PSE", Name = "Mercedita" },
                new AirportInfo { Code = "PSG", Name = "James C. Johnson Petersburg" },
                new AirportInfo { Code = "PSP", Name = "Palm Springs International" },
                new AirportInfo { Code = "PUB", Name = "Pueblo Memorial" },
                new AirportInfo { Code = "PWM", Name = "Portland International Jetport" },
                new AirportInfo { Code = "RAP", Name = "Rapid City Regional" },
                new AirportInfo { Code = "RDD", Name = "Redding Municipal" },
                new AirportInfo { Code = "RDM", Name = "Roberts" },
                new AirportInfo { Code = "RFD", Name = "Greater Rockford" },
                new AirportInfo { Code = "RHI", Name = "Rhinelander-Oneida County" },
                new AirportInfo { Code = "RKS", Name = "Rock Springs-Sweetwater County" },
                new AirportInfo { Code = "ROA", Name = "Roanoke Regional  Woodrum" },
                new AirportInfo { Code = "ROC", Name = "Greater Rochester Int'l" },
                new AirportInfo { Code = "ROW", Name = "Roswell Industrial Air Center" },
                new AirportInfo { Code = "RST", Name = "Rochester International" },
                new AirportInfo { Code = "SAF", Name = "Santa Fe Municipal" },
                new AirportInfo { Code = "SAV", Name = "Savannah International" },
                new AirportInfo { Code = "SBA", Name = "Santa Barbara Municipal" },
                new AirportInfo { Code = "SBN", Name = "South Bend Regional" },
                new AirportInfo { Code = "SBP", Name = "San Luis Obispo Co-McChesney" },
                new AirportInfo { Code = "SCC", Name = "Deadhorse" },
                new AirportInfo { Code = "SCE", Name = "University Park" },
                new AirportInfo { Code = "SGF", Name = "Springfield-Branson Regional" },
                new AirportInfo { Code = "SGU", Name = "St George Muni" },
                new AirportInfo { Code = "SHD", Name = "Shenandoah Valley Regional" },
                new AirportInfo { Code = "SHV", Name = "Shreveport Regional" },
                new AirportInfo { Code = "SIT", Name = "Sitka" },
                new AirportInfo { Code = "SJT", Name = "San Angelo Regional  Mathis" },
                new AirportInfo { Code = "SMX", Name = "Santa Maria Pub Capt G Allan Hancock" },
                new AirportInfo { Code = "SPI", Name = "Capital" },
                new AirportInfo { Code = "SPN", Name = "Tinian International Airport" },
                new AirportInfo { Code = "SPS", Name = "Sheppard AFB Wichita Falls Municipal" },
                new AirportInfo { Code = "SRQ", Name = "Sarasota Bradenton International" },
                new AirportInfo { Code = "STC", Name = "St Cloud Regional" },
                new AirportInfo { Code = "STT", Name = "Cyril E. King" },
                new AirportInfo { Code = "STX", Name = "Henry E. Rohlsen" },
                new AirportInfo { Code = "SUN", Name = "Friedman Memorial" },
                new AirportInfo { Code = "SUX", Name = "Sioux Gateway" },
                new AirportInfo { Code = "SWF", Name = "Stewart" },
                new AirportInfo { Code = "SYR", Name = "Syracuse-Hancock Intl" },
                new AirportInfo { Code = "TEX", Name = "Telluride Regional" },
                new AirportInfo { Code = "TLH", Name = "Tallahassee Regional" },
                new AirportInfo { Code = "TOL", Name = "Toledo Express" },
                new AirportInfo { Code = "TRI", Name = "Tri-Cities Regional" },
                new AirportInfo { Code = "TTN", Name = "Trenton-Mercer County" },
                new AirportInfo { Code = "TUP", Name = "Tupelo Municipal" },
                new AirportInfo { Code = "TVC", Name = "Cherry Capital" },
                new AirportInfo { Code = "TWF", Name = "Joslin Field - Magic Valley" },
                new AirportInfo { Code = "TXK", Name = "Texarkana Regional-Webb" },
                new AirportInfo { Code = "TYR", Name = "Tyler Pounds" },
                new AirportInfo { Code = "TYS", Name = "McGhee-Tyson" },
                new AirportInfo { Code = "VEL", Name = "Vernal" },
                new AirportInfo { Code = "VLD", Name = "Valdosta Regional" },
                new AirportInfo { Code = "VPS", Name = "Eglin Air Force Base" },
                new AirportInfo { Code = "WRG", Name = "Wrangell" },
                new AirportInfo { Code = "WYS", Name = "Yellowstone" },
                new AirportInfo { Code = "XNA", Name = "Northwest Arkansas Regional" },
                new AirportInfo { Code = "YAK", Name = "Yakutat" },
                new AirportInfo { Code = "YUM", Name = "Yuma MCAS-Yuma International" }
            };
        }
    }


    public class AirportInfo
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}

