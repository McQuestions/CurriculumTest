using CurriculumTest;
using CurriculumTest.Pages.Index.IndexComponents;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CurriculumTest
{
	//  Class die static rand bevat zodat in de rand geen patronen herkenbaar zijn
	// Dit kleine stukje code is waarschijnlijk de meest gebruikte code van het hele project
	public class Rand
	{
		static Random ranDom = new();
		public static Random GetRandom => ranDom;
	}

	// Class die het echte werk doet bij het samenstellen van de kleurcombinaties
	///////////////////////////////////////////////////
	public class Colors
	{
		public Colors()
		{
			KleurenBoek = new();
			KleurenBoekCreate = new();
		}

		#region MyRegion
		//private Dictionary<string, string> _kleurenBoek;
		public Dictionary<string, string> KleurenBoek { get; set; }

		private Dictionary<string, string> _kleurenBoekCreate;
		public Dictionary<string, string> KleurenBoekCreate { get; set; }

		public static string Button;
		//Dit zijn de kleuren die in de bovenstaande method worden geset en in de css van de indexpagina worden gebruikt.
		public int Basis;
		public int Contrast;
		public int Min;
		public int Plus;
		// deze zorgen ervoor dat de kleurkeuze buttons op de indexpagina de juiste kleur krijgen
		public static string Rood { get => "hsl(0,   100%, 50%);"; }
		public static string Geel { get => "hsl(60,  100%, 50%);"; }
		public static string Groen { get => "hsl(120, 100%, 50%);"; }
		public static string Cyaan { get => "hsl(180, 100%, 50%);"; }
		public static string Blauw { get => "hsl(240, 100%, 50%);"; }
		public static string Magenta { get => "hsl(300, 100%, 50%);"; }

		#endregion

		// /////////////////////////////////////////////////////////////////////////////////
		// /////////////////////////////////////////////////////////////////////////////////

		#region Sleutels voor strings kleurwaarden CSS
		public string Bg_Grid_Container_Background { get; set; } = "Bg_Grid_Container_Background";
		public string Bg_Grid_Container_Div { get; set; } = "Bg_Grid_Container_Div";  //color: hsl(@Colours.basisKleur_Min,77%,65%); 

		public string Bg_Item1_Background { get; set; } = "Bg_Item1_Background";
		public string Bg_Item2_Background { get; set; } = "Bg_Item2_Background";
		public string Bg_Item3_Background { get; set; } = "Bg_Item3_Background";
		public string Bg_Item4_Background { get; set; } = "Bg_Item4_Background";
		public string Bg_Item5_Background { get; set; } = "Bg_Item5_Background";
		public string Bg_Item6_Background { get; set; } = "Bg_Item6_Background";
		public string Bg_Item7_Background { get; set; } = "Bg_Item7_Background";
		public string Bg_Item7_Border { get; set; } = "Bg_Item7_Border";
		public string Bg_Item8_Background { get; set; } = "Bg_Item8_Background";
		public string Bg_Item9_Background { get; set; } = "Bg_Item9_Background";
		public string Bg_Item10_Background_Image { get; set; } = "Bg_Item10_Background_Image";
		public string Bg_Item11_Background { get; set; } = "Bg_Item11_Background";
		public string Bg_Item12_Background { get; set; } = "Bg_Item12_Background";
		public string Bg_Item12_Border { get; set; } = "Bg_Item12_Border";
		public string Bg_Item13_Background { get; set; } = "Bg_Item13_Background";
		public string Bg_Item14_Background { get; set; } = "Bg_Item14_Background";
		public string Bg_Item15_Background { get; set; } = "Bg_Item15_Background";
		public string Btn_Primary_Background { get; set; } = "Btn_Primary_Background";
		public string Btn_Primary_Hover_Background { get; set; } = "Btn_Primary_Hover_Background";
		public string DataDrager_Dating_Background { get; set; } = "DataDrager_Dating_Background";
		public string DataDrager_B_Background { get; set; } = "DataDrager_B_Background";
		public string Divcolorbuttons_Background { get; set; } = "Divcolorbuttons_Background";
		public string Fieldset_Background { get; set; } = "Fieldset_Background";
		public string Fieldset_Even_Background { get; set; } = "Fieldset_Even_Background";
		public string HouseofcolorsBEE_Background { get; set; } = "HouseofcolorsBEE_Background";
		public string HouseofcolorsHoC_Background { get; set; } = "HouseofcolorsHoC_Background";
		public string HouseofcolorsHusk_Background { get; set; } = "HouseofcolorsHusk_Background";
		public string HouseofcolorsHeerlen_Background { get; set; } = "HouseofcolorsHeerlen_Background";
		public string InputBackground { get; set; } = "InputBackground";
		public string Legend_Span_Background { get; set; } = "Legend_Span_Background";
		public string Nuance1_Background { get; set; } = "Nuance1_Background";
		public string Nuance2_Background { get; set; } = "Nuance2_Background";
		public string Nuance3_Background { get; set; } = "Nuance3_Background";
		public string Nuance4_Background { get; set; } = "Nuance4_Background";
		public string Nuance5_Background { get; set; } = "Nuance5_Background";
		public string Nuance6_Background { get; set; } = "Nuance6_Background";
		public string Pictureframe_Background_Image { get; set; } = "Pictureframe_Background_Image";
		#endregion

		public void VulKleurenboek()
		{
			KleurenBoek.Add(Bg_Grid_Container_Background, $"hsl({Basis},      50%, 12%) !important");
			KleurenBoek.Add(Bg_Grid_Container_Div, $"hsl({Min},        77%, 65%) !important");

			KleurenBoek.Add(Btn_Primary_Background, $"hsl({Basis},            98%, 48%)");
			KleurenBoek.Add(Btn_Primary_Hover_Background, $"hsl({(Basis + 20)},     100%,50%)");

			KleurenBoek.Add(DataDrager_Dating_Background, $"hsl({Basis},      25%, 98%) !important");
			KleurenBoek.Add(DataDrager_B_Background, $"hsl({Basis},      20%, 30%) !important");
			KleurenBoek.Add(Divcolorbuttons_Background, $"hsl({Basis},      20%, 60%) !important");

			KleurenBoek.Add(Fieldset_Background, $"hsl({Basis},      {Rand.GetRandom.Next(30, 40)}%, {Rand.GetRandom.Next(98, 100)}%) !important");
			KleurenBoek.Add(Fieldset_Even_Background, $"hsl({Plus},       30%, {Rand.GetRandom.Next(97, 99)}%) !important");

			KleurenBoek.Add(HouseofcolorsBEE_Background, $"hsl({Basis},      1%,50%)");
			KleurenBoek.Add(HouseofcolorsHoC_Background, $"hsl({Contrast},   1%,50%)");
			KleurenBoek.Add(HouseofcolorsHusk_Background, $"hsl({Plus},       1%,50%)");
			KleurenBoek.Add(HouseofcolorsHeerlen_Background, $"hsl({Min},        1%,50%)");

			KleurenBoek.Add(InputBackground, $"hsl({Basis},      35%,99%) !important");

			KleurenBoek.Add(Legend_Span_Background, $"hsl({Min},      5%, 45%) !important");

			KleurenBoek.Add(Pictureframe_Background_Image, $"linear-gradient(to left top, hsl({Basis}, 0%, 98%), hsl({Basis}, 0%, 92%))");
			//KleurenBoek.Add(Pictureframe_Background_Image, $"linear-gradient(to left top, hsl({Basis}, 0%, 70%), hsl({Basis}, {Rand.GetRandom.Next(1, 3)}%, 60%))");
		}
		public void VulKleurenboekCreate()
		{
			KleurenBoekCreate.Add(Bg_Grid_Container_Background, $"hsl({Basis},      50%, 12%) !important");
			KleurenBoekCreate.Add(Bg_Grid_Container_Div, $"hsl({Min},        77%, 65%) !important");

			KleurenBoekCreate.Add(Btn_Primary_Background, $"hsl({Basis},            98%, 48%)");
			KleurenBoekCreate.Add(Btn_Primary_Hover_Background, $"hsl({(Basis + 20)},     100%,50%)");

			KleurenBoekCreate.Add(DataDrager_Dating_Background, $"hsl({Basis},      25%, 98%) !important");
			KleurenBoekCreate.Add(DataDrager_B_Background, $"hsl({Basis},      1%, 98%) !important");
			KleurenBoekCreate.Add(Divcolorbuttons_Background, $"hsl({Basis},      20%, 60%) !important");

			KleurenBoekCreate.Add(Fieldset_Background, $"hsl({Basis},      {Rand.GetRandom.Next(30, 40)}%, {Rand.GetRandom.Next(98, 100)}%) !important");
			KleurenBoekCreate.Add(Fieldset_Even_Background, $"hsl({Plus},       30%, {Rand.GetRandom.Next(97, 99)}%) !important");

			KleurenBoekCreate.Add(HouseofcolorsBEE_Background, $"hsl({Basis},      1%,50%)");
			KleurenBoekCreate.Add(HouseofcolorsHoC_Background, $"hsl({Contrast},   1%,50%)");
			KleurenBoekCreate.Add(HouseofcolorsHusk_Background, $"hsl({Plus},       1%,50%)");
			KleurenBoekCreate.Add(HouseofcolorsHeerlen_Background, $"hsl({Min},        1%,50%)");

			KleurenBoekCreate.Add(InputBackground, $"hsl({Basis},      35%,99%) !important");

			KleurenBoekCreate.Add(Legend_Span_Background, $"hsl({Min},      5%, 45%) !important");

			KleurenBoekCreate.Add(Pictureframe_Background_Image, $"linear-gradient(to left top, hsl({Basis}, 0%, 98%), hsl({Basis}, 0%, 92%))");
			//KleurenBoekCreate.Add(Pictureframe_Background_Image, $"linear-gradient(to left top, hsl({Basis}, 0%, 70%), hsl({Basis}, {Rand.GetRandom.Next(1, 3)}%, 60%))");
		}
		// /////////////////////////////////////////////////////////////////////////////////
		// /////////////////////////////////////////////////////////////////////////////////
		// Eigenlijk zou dit een void moeten zijn maar die kan (voorzover onze kennis reikt) niet vanaf een andere component worden aangeroepen
		// de return value van deze method wordt niet gebruikt. De method zet de values van de vier kleuren die gebruikt worden 
		// voor de kleurcombinatie.
		public int SetValues(string buttn, int minMax)
		{
			KleurenBoek.Clear();
			int x = 0;
			if (buttn == "Rood")
			{
				int xx = Rand.GetRandom.Next(330, 360);
				int xxx = Rand.GetRandom.Next(0, 30);
				int xxxx = Rand.GetRandom.Next(1, 3);

				if (xxxx % 2 == 0) // de operator % laat de (eventuele) rest zien van een deling. Ideaal icm een randwaarde.                                   
					x = xx; // if en else kun je ook zonder {} schrijven als ze maar 1 statement bevatten
				else
					x = xxx;
			}

			if (buttn == "Geel")
			{ x = Rand.GetRandom.Next(30, 90); } // 30 en 90 zijn de grenzen tussen rood/geel en geel/groen. dit is het gebied
												 // waaruit de random de basiskleur trekt

			if (buttn == "Groen")
			{ x = Rand.GetRandom.Next(90, 150); }

			if (buttn == "Cyaan")
			{ x = Rand.GetRandom.Next(150, 210); }

			if (buttn == "Blauw")
			{ x = Rand.GetRandom.Next(210, 270); }

			if (buttn == "Magenta")
			{ x = Rand.GetRandom.Next(270, 330); }

			#region MyRegion
			Basis = x;


			//if (x + 180 >= 360)
			//{ Contrast = x + 180 - 360; }
			if (x > 179)
			{ Contrast = x - 180; }
			else
			{ Contrast = x + 180; }

			if (Basis % 2 == 0)
			{
				if (x + minMax >= 360)
				{ Plus = x + minMax - 360; }
				else
				{ Plus = x + minMax; }

				if (x - minMax < 0)
				{ Min = x + 360 - minMax; }
				else
				{ Min = x - minMax; }
			}
			else
			{
				if (x + minMax >= 360)
				{ Min = x + minMax - 360; }
				else
				{ Min = x + minMax; }

				if (x - minMax < 0)
				{ Plus = x + 360 - minMax; }
				else
				{ Plus = x - minMax; }
			}
			#endregion

			VulKleurenboek();
			return 0;
		}

		public int SetValuesCreate(string buttn, int minmax)
		{
			KleurenBoekCreate.Clear();
			int x = 0;
			if (buttn == "Rood")
			{
				int xx = Rand.GetRandom.Next(330, 360);
				int xxx = Rand.GetRandom.Next(0, 30);
				int xxxx = Rand.GetRandom.Next(1, 3);

				if (xxxx % 2 == 0) // de operator % laat de (eventuele) rest zien van een deling. Ideaal icm een randwaarde.                                   
					x = xx; // if en else kun je ook zonder {} schrijven als ze maar 1 statement bevatten
				else
					x = xxx;
			}

			if (buttn == "Geel")
			{ x = Rand.GetRandom.Next(30, 90); } // 30 en 90 zijn de grenzen tussen rood/geel en geel/groen. dit is het gebied
												 // waaruit de random de basiskleur trekt

			if (buttn == "Groen")
			{ x = Rand.GetRandom.Next(90, 150); }

			if (buttn == "Cyaan")
			{ x = Rand.GetRandom.Next(150, 210); }

			if (buttn == "Blauw")
			{ x = Rand.GetRandom.Next(210, 270); }

			if (buttn == "Magenta")
			{ x = Rand.GetRandom.Next(270, 330); }

			#region MyRegion
			Basis = x;

			if (x + 180 >= 360)
			{ Contrast = x + 180 - 360; }
			else
			{ Contrast = x + 180; }

			if (Basis % 2 == 0)
			{
				if (x + minmax >= 360)
				{ Plus = x + minmax - 360; }
				else
				{ Plus = x + minmax; }

				if (x - minmax < 0)
				{ Min = x + 360 - minmax; }
				else
				{ Min = x - minmax; }
			}
			else
			{
				if (x + minmax >= 360)
				{ Min = x + minmax - 360; }
				else
				{ Min = x + minmax; }

				if (x - minmax < 0)
				{ Plus = x + 360 - minmax; }
				else
				{ Plus = x - minmax; }
			}
			#endregion

			VulKleurenboekCreate();
			return 0;
		}

		// Deze methods worden in de css gebruikt om de css string te creeren. Dit is een onderdeel dat niet af is en er
		// zouden er nog een paar bij moeten zodat we ook de andere kleuren uit het pakket kant en klaar in stringvorm op de 
		// indexagina kunnen gebruiken
		public string basisKleurSL(int smin, int smx, int lmin, int lmax)
		{
			string sat = Rand.GetRandom.Next(smin, smx).ToString();

			int helderheid = Rand.GetRandom.Next(lmin, lmax);
			string light = helderheid.ToString();

			string bk = Basis.ToString() + ", " + sat.ToString() + "%, " + light.ToString() + "%";

			return bk;
		}

		public string basisKleurTegenoverSL(int smin, int smx, int lmin, int lmax)
		{
			string bk = "";
			string sat = Rand.GetRandom.Next(smin, smx).ToString();
			string light = Rand.GetRandom.Next(lmin, lmax).ToString();

			bk = "hsl(" + Basis.ToString() + ", " + sat.ToString() + "%, " + light.ToString() + "%);";

			return bk;
		}
	}
}






