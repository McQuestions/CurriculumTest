using System;
using System.Text;
using System.Xml.Linq;

namespace CurriculumTest
{
	// De classes om de data te lezen en schrijven en in de html te gebruiken
	public class XMLDataCreate
	{
		static Random ranDom = new();
		static Random getRandom => ranDom;
		public XMLDataCreate()
		{
			Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
			String path = Directory.GetCurrentDirectory();
			AllXMLContent = XElement.Load(path + "\\Xml" + "\\XMLDataInput.xml");
			Records = AllXMLContent.Elements().ToList();
		}

		public XElement AllXMLContent { get; set; }
		public XElement Record { get; set; }
		public List<XElement> Records { get; set; }
		int randIndex { get; set; } = 0;

		private Curriculum _curriculumCreate;
		public Curriculum GetCurriculumCreate(int index)
		{
			//int aantalRecords = Records.Count();
			//randIndex = getRandom.Next(0,aantalRecords); 
			Record = Records[index];
			_curriculumCreate = new Curriculum();

			_curriculumCreate.Access = Record.Element("access").Value;
			_curriculumCreate.Id = (string)Record.Element("id").Value;
			_curriculumCreate.Meta = Record.Element("meta").Value;

			foreach (var ite in Record.Element("card_dating").Elements())
			{
				Dating dating = new()
				{
					Show = ((bool)ite.Element("show")),
					Voornaam = ite.Element("voornaam").Value,
					Tussenvoegsel = ite.Element("tussenvoegsel").Value,
					Achternaam = ite.Element("achternaam").Value,
					Foto = ite.Element("foto").Value,
					Leeftijd = ite.Element("leeftijd").Value
				};
				_curriculumCreate.ListDating.Add(dating);
			}

			foreach (var ite in Record.Element("card_professional").Elements())
			{
				Professional professional = new()
				{
					Beroep = ite.Element("beroep").Value,
					BIG_Registratie = ite.Element("big_registratie").Value,
					Thuiswerken = ite.Element("thuiswerken").Value,
					ZoekVoorAantalUren = ite.Element("zoekvooraantaluren").Value,
					ZoekWerkInRegio = ite.Element("zoekwerkinregio").Value,
					Zzp = ite.Element("zzp").Value,
					ZoektOpleidingsmogelijkheden = ite.Element("zoektOpleidingsmogelijkheden").Value,
					ZoektGroeimogelijkheden = ite.Element("zoektGroeimogelijkheden").Value,
					Huisvesting = ite.Element("huisvesting").Value
				};
				_curriculumCreate.ListProfessional.Add(professional);
			}

			foreach (var ite in Record.Element("card_communications").Elements())
			{
				Communications communications = new()
				{
					Show = ((bool)ite.Element("show")),
					Email = ite.Element("email").Value,
					Telefoon = ite.Element("telefoon").Value,
					Gemeente = ite.Element("gemeente").Value
				};
				_curriculumCreate.ListCommunications.Add(communications);
			}

			foreach (var ite in Record.Element("card_location").Elements())
			{
				Location location = new()
				{
					Show = ((bool)ite.Element("show")),
					Adres = ite.Element("adres").Value,
					Postcode = ite.Element("postcode").Value,
					Woonplaats = ite.Element("woonplaats").Value
				};
				_curriculumCreate.ListLocation.Add(location);
			}

			foreach (var ite in Record.Element("card_workexperience").Elements())
			{
				WorkExperience werkerv = new()
				{
					Show = ((bool)ite.Element("show")),
					Werkgever = ite.Element("werkgever").Value,
					Functie = ite.Element("functie").Value,
					Periode = ite.Element("periode").Value,
					Referenties = ite.Element("referenties").Value
				};
				_curriculumCreate.ListWorkExperience.Add(werkerv);
			}

			foreach (var ite in Record.Element("card_education").Elements())
			{
				Education opl = new Education
				{
					Show = ((bool)ite.Element("show")),
					NaamEducation = ite.Element("naameducation").Value,
					Niveau = ite.Element("niveau").Value,
					Diploma = ite.Element("diploma").Value,
					Toelichting = ite.Element("toelichting").Value
				};
				_curriculumCreate.ListEducation.Add(opl);
			}

			foreach (var ite in Record.Element("card_vaardigheden").Elements())
			{
				Skill skill = new()
				{
					Show = ((bool)ite.Element("show")),
					Omschrijving = ite.Element("omschrijving").Value,
					Toelichting = ite.Element("toelichting").Value
				};
				_curriculumCreate.ListSkills.Add(skill);
			}

			foreach (var ite in Record.Element("card_vrijetijdsbesteding").Elements())
			{
				Vrijetijdsbesteding vrijetijd = new Vrijetijdsbesteding
				{
					Show = ((bool)ite.Element("show")),
					Activiteit = ite.Element("activiteit").Value
				};
				_curriculumCreate.ListVrijetijdsbesteding.Add(vrijetijd);
			}

			foreach (var ite in Record.Element("card_referentie").Elements())
			{
				Referentie referentie = new Referentie
				{
					Show = ((bool)ite.Element("show")),
					Naam = ite.Element("naam").Value,
					Functie = ite.Element("functie").Value
				};
				_curriculumCreate.ListReferentie.Add(referentie);
			}

			foreach (var ite in Record.Element("card_tool").Elements())
			{
				Tool tool = new Tool();
				tool.Show = ((bool)ite.Element("show"));
				tool.ExperienceLevel = ite.Element("experiencelevel").Value;
				_curriculumCreate.ListTools.Add(tool);
			}

			foreach (var ite in Record.Element("card_training").Elements())
			{
				Training training = new Training
				{
					Show = ((bool)ite.Element("show")),
					Naam = ite.Element("naam").Value,
					Toelichting = ite.Element("toelichting").Value
				};
				_curriculumCreate.ListTraining.Add(training);
			}

			foreach (var ite in Record.Element("card_cursus").Elements())
			{
				Cursus cursus = new Cursus
				{
					Show = ((bool)ite.Element("show")),
					Naam = ite.Element("naam").Value,
					Toelichting = ite.Element("toelichting").Value
				};
				_curriculumCreate.ListCursus.Add(cursus);
			}

			foreach (var ite in Record.Element("card_certificaat").Elements())
			{
				Certificate certificaat = new()
				{
					Show = ((bool)ite.Element("show")),
					Naam = ite.Element("naam").Value,
					Toelichting = ite.Element("toelichting").Value
				};
				_curriculumCreate.ListCertificates.Add(certificaat);
			}
			return _curriculumCreate;
		}

		private Curriculum _curriculumShow;
		public Curriculum GetCurriculumShow()
		{

			//Record.Descendants().Where(e => string.IsNullOrEmpty(e.Value)).Remove();

			_curriculumShow = new Curriculum();

			if (!Record.Element("access").IsEmpty)
			{
				_curriculumShow.Access = Record.Element("access").Value;
			}

			if (!Record.Element("access").IsEmpty)
			{
				_curriculumShow.Id = Record.Element("id").Value;
			}

			if (!Record.Element("access").IsEmpty)
			{
				_curriculumShow.Meta = Record.Element("meta").Value;
			}

			foreach (var ite in Record.Element("card_dating").Elements())
			{
				Dating dating = new()
				{
					Show = ((bool)ite.Element("show")),
					Voornaam = ite.Element("voornaam").Value,
					Tussenvoegsel = ite.Element("tussenvoegsel").Value,
					Achternaam = ite.Element("achternaam").Value,
					Foto = ite.Element("foto").Value,
					Leeftijd = ite.Element("leeftijd").Value
				};

				_curriculumShow.ListDating.Add(dating);
			}

			foreach (var ite in Record.Element("card_communications").Elements())
			{
				Communications communications = new();
				communications.Show = ((bool)ite.Element("show"));
				communications.Email = ite.Element("email").Value;
				communications.Telefoon = ite.Element("telefoon").Value;
				communications.Gemeente = ite.Element("gemeente").Value;

				_curriculumShow.ListCommunications.Add(communications);
			}

			foreach (var ite in Record.Element("card_location").Elements())
			{
				Location location = new();
				location.Show = ((bool)ite.Element("show"));
				location.Adres = ite.Element("adres").Value;
				location.Postcode = ite.Element("postcode").Value;
				location.Woonplaats = ite.Element("woonplaats").Value;

				_curriculumShow.ListLocation.Add(location);
			}



			foreach (var ite in Record.Element("card_workexperience").Elements())
			{
				WorkExperience werkerv = new();
				werkerv.Show = ((bool)ite.Element("show"));
				werkerv.Werkgever = ite.Element("werkgever").Value;
				werkerv.Functie = ite.Element("functie").Value;
				werkerv.Periode = ite.Element("periode").Value;
				werkerv.Referenties = ite.Element("referenties").Value;
				_curriculumShow.ListWorkExperience.Add(werkerv);
			}

			foreach (var ite in Record.Element("card_education").Elements())
			{
				Education opl = new Education();
				opl.Show = ((bool)ite.Element("show"));
				opl.NaamEducation = ite.Element("naameducation").Value;
				opl.Niveau = ite.Element("niveau").Value;
				opl.Diploma = ite.Element("diploma").Value;
				opl.Toelichting = ite.Element("toelichting").Value;
				_curriculumShow.ListEducation.Add(opl);
			}

			foreach (var ite in Record.Element("card_vaardigheden").Elements())
			{
				Skill skill = new();
				skill.Show = ((bool)ite.Element("show"));
				skill.Omschrijving = ite.Element("omschrijving").Value;
				skill.Toelichting = ite.Element("toelichting").Value;
				_curriculumShow.ListSkills.Add(skill);
			}

			foreach (var ite in Record.Element("card_vrijetijdsbesteding").Elements())
			{
				Vrijetijdsbesteding vrijetijd = new Vrijetijdsbesteding();
				vrijetijd.Show = ((bool)ite.Element("show"));
				vrijetijd.Activiteit = ite.Element("activiteit").Value;
				_curriculumShow.ListVrijetijdsbesteding.Add(vrijetijd);
			}

			foreach (var ite in Record.Element("card_referentie").Elements())
			{
				Referentie referentie = new Referentie();
				referentie.Show = ((bool)ite.Element("show"));
				referentie.Naam = ite.Element("naam").Value;
				referentie.Functie = ite.Element("functie").Value;
				_curriculumShow.ListReferentie.Add(referentie);
			}

			foreach (var ite in Record.Element("card_tool").Elements())
			{
				Tool tool = new Tool();
				tool.Show = ((bool)ite.Element("show"));
				tool.ExperienceLevel = ite.Element("experiencelevel").Value;
				_curriculumShow.ListTools.Add(tool);
			}

			foreach (var ite in Record.Element("card_training").Elements())
			{
				Training training = new Training();
				training.Show = ((bool)ite.Element("show"));
				training.Naam = ite.Element("naam").Value;
				training.Toelichting = ite.Element("toelichting").Value;
				_curriculumShow.ListTraining.Add(training);
			}

			foreach (var ite in Record.Element("card_cursus").Elements())
			{
				Cursus cursus = new Cursus();
				cursus.Show = ((bool)ite.Element("show"));
				cursus.Naam = ite.Element("naam").Value;
				cursus.Toelichting = ite.Element("toelichting").Value;
				_curriculumShow.ListCursus.Add(cursus);
			}

			foreach (var ite in Record.Element("card_certificaat").Elements())
			{
				Certificate certificaat = new();
				certificaat.Show = ((bool)ite.Element("show"));
				certificaat.Naam = ite.Element("naam").Value;
				certificaat.Toelichting = ite.Element("toelichting").Value;
				_curriculumShow.ListCertificates.Add(certificaat);
			}
			return _curriculumShow;
		}

		public void Save(Curriculum C)
		{
			IEnumerable<XElement> LoopDating()
			{
				foreach (var item in C.ListDating)
				{
					XElement LW = new XElement("dating",
						new XElement("show", item.Show),
						new XElement("voornaam", item.Voornaam),
						new XElement("tussenvoegsel", item.Tussenvoegsel),
						new XElement("achternaam", item.Achternaam),
						new XElement("foto", item.Foto),
						new XElement("leeftijd", item.Leeftijd));
					yield return LW;
				}
			}

			IEnumerable<XElement> LoopProfessional()
			{
				foreach (var item in C.ListProfessional)
				{
					XElement LW = new XElement("professional",
						new XElement("beroep", item.Beroep),
						new XElement("big_registratie", item.BIG_Registratie),
						new XElement("thuiswerken", item.Thuiswerken),
						new XElement("zoekvooraantaluren", item.ZoekVoorAantalUren),
						new XElement("zoekwerkinregio", item.ZoekWerkInRegio),
						new XElement("zzp", item.Zzp),
						new XElement("zoektOpleidingsmogelijkheden", item.ZoektOpleidingsmogelijkheden),
						new XElement("zoektGroeimogelijkheden", item.ZoektGroeimogelijkheden),
						new XElement("huisvesting", item.Huisvesting)
						);
					yield return LW;
				}
			}

			IEnumerable<XElement> LoopLocation()
			{
				foreach (var item in C.ListLocation)
				{
					XElement LW = new XElement("location",
						new XElement("show", item.Show),
						new XElement("adres", item.Adres),
						new XElement("postcode", item.Postcode),
						new XElement("woonplaats", item.Woonplaats));
					yield return LW;
				}
			}

			IEnumerable<XElement> LoopCommunications()
			{
				foreach (var item in C.ListCommunications)
				{
					XElement LW = new XElement("communications",
						new XElement("show", item.Show),
						new XElement("email", item.Email),
						new XElement("telefoon", item.Telefoon),
						new XElement("gemeente", item.Gemeente));
					yield return LW;
				}
			}

			IEnumerable<XElement> LoopW()
			{
				foreach (var item in C.ListWorkExperience)
				{
					XElement LW = new XElement("workexperience",
						new XElement("show", item.Show),
						new XElement("id", item.Id),
						new XElement("werkgever", item.Werkgever),
						new XElement("functie", item.Functie),
						new XElement("periode", item.Periode),
						new XElement("referenties", item.Referenties));
					yield return LW;
				}
			}

			IEnumerable<XElement> LoopO()
			{
				foreach (var item in C.ListEducation)
				{
					XElement LO = new XElement("education",
						new XElement("show", item.Show),
						new XElement("id", item.Id),
						new XElement("naameducation", item.NaamEducation),
						new XElement("niveau", item.Niveau),
						new XElement("diploma", item.Diploma),
						new XElement("toelichting", item.Toelichting));
					yield return LO;
				}
			}

			IEnumerable<XElement> LoopV()
			{
				foreach (var item in C.ListSkills)
				{
					XElement LV = new XElement("vaardigheden",
						new XElement("show", item.Show),
						new XElement("id", item.Id),
						new XElement("omschrijving", item.Omschrijving),
						new XElement("toelichting", item.Toelichting));

					yield return LV;
				}
			}

			IEnumerable<XElement> LoopVB()
			{
				foreach (var item in C.ListVrijetijdsbesteding)
				{
					XElement LVB = new XElement("vrijetijdsbesteding",
						new XElement("show", item.Show),
						new XElement("id", item.Id),
						new XElement("activiteit", item.Activiteit));
					yield return LVB;
				}
			}

			IEnumerable<XElement> LoopR()
			{
				foreach (var item in C.ListReferentie)
				{
					XElement LR = new XElement("referentie",
						new XElement("show", item.Show),
						new XElement("id", item.Id),
						new XElement("naam", item.Naam),
						new XElement("functie", item.Functie));
					yield return LR;
				}
			}

			IEnumerable<XElement> LoopT()
			{
				foreach (var item in C.ListTools)
				{
					XElement LT = new XElement("tool",
						new XElement("show", item.Show),
						new XElement("id", item.Id),
						new XElement("experiencelevel", item.ExperienceLevel));
					yield return LT;
				}
			}

			IEnumerable<XElement> LoopTraining()
			{
				foreach (var item in C.ListTraining)
				{
					XElement LTraining = new XElement("training",
						new XElement("show", item.Show),
						new XElement("id", item.Id),
						new XElement("naam", item.Naam),
						new XElement("toelichting", item.Toelichting)
						);
					yield return LTraining;
				}
			}

			IEnumerable<XElement> LoopCursus()
			{
				foreach (var item in C.ListCursus)
				{
					XElement LCursus = new XElement("cursus",
						new XElement("show", item.Show),
						new XElement("id", item.Id),
						new XElement("naam", item.Naam),
						new XElement("toelichting", item.Toelichting)
						);
					yield return LCursus;
				}
			}

			IEnumerable<XElement> LoopCertificaat()
			{
				foreach (var item in C.ListCertificates)
				{
					XElement LCertificaat = new XElement("certificaat",
						new XElement("show", item.Show),
						new XElement("id", item.Id),
						new XElement("naam", item.Naam),
						new XElement("toelichting", item.Toelichting)
						);
					yield return LCertificaat;
				}
			}

			XElement changedXelement = new XElement("cv",
				new XElement("access", C.Access),
				new XElement("id", C.Id),
				new XElement("meta", C.Meta),
				new XElement("card_dating",	LoopDating()),
				new XElement("card_Professional", LoopProfessional()),
				new XElement("card_location", LoopLocation()),
				new XElement("card_communications", LoopCommunications()),
				new XElement("card_workexperience", LoopW()),
				new XElement("card_education", LoopO()),
				new XElement("card_vaardigheden", LoopV()),
				new XElement("card_vrijetijdsbesteding", LoopVB()),
				new XElement("card_referentie", LoopR()),
				new XElement("card_tool", LoopT()),
				new XElement("card_cursus", LoopCursus()),
				new XElement("card_certificaat", LoopCertificaat()),
				new XElement("card_training", LoopTraining())
				);

			AllXMLContent.Add(changedXelement);
			Records[randIndex] = changedXelement;

			Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
			String path = Directory.GetCurrentDirectory();
			AllXMLContent.Save(path + "\\Xml" + "\\XMLDataInput.xml");
			AllXMLContent.Save(@"C:\Users\Admin\source\repos\CurriculumTest\CurriculumTest\Xml\XMLDataInput.xml");
		}
	}

	//public class XMLDataInput
	//   {
	//	static Random ranDom = new();
	//       static Random getRandom => ranDom;
	//       public XMLDataInput()
	//       {
	//           Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
	//           String path = Directory.GetCurrentDirectory();
	//           AllXMLContent = XElement.Load(path + "\\Xml" + "\\XMLDataInput.xml");
	//           Records = AllXMLContent.Elements().ToList();
	//		int aantalRecords = Records.Count();
	//		randIndex = getRandom.Next(0,aantalRecords); 
	//		Record = Records[randIndex];
	//       }

	//	public XElement AllXMLContent { get; set; }
	//	public XElement Record { get; set; }
	//       public List<XElement> Records { get; set; }
	//	int randIndex { get; set; } = 0;

	//	private Curriculum _curriculum;
	//       public Curriculum GetCurriculum()
	//       {
	//           _curriculum = new Curriculum();

	//           _curriculum.Access = Record.Element("access").Value;
	//           _curriculum.Voornaam = Record.Element("voornaam").Value;
	//           _curriculum.Tussenvoegsel = Record.Element("tussenvoegsel").Value;
	//           _curriculum.Achternaam = Record.Element("achternaam").Value;
	//           _curriculum.Leeftijd = int.Parse(Record.Element("leeftijd").Value);
	//           _curriculum.Adres = Record.Element("adres").Value;
	//           _curriculum.Postcode = Record.Element("postcode").Value;
	//           _curriculum.Woonplaats = Record.Element("woonplaats").Value;
	//           _curriculum.Email = Record.Element("email").Value;
	//           _curriculum.Telefoon = Record.Element("telefoon").Value;
	//           _curriculum.Foto = Record.Element("foto").Value;

	//           _curriculum.Meta = Record.Element("meta").Value;













	//           foreach (var ite in Record.Element("card_workexperience").Elements())
	//           {
	//               WorkExperience werkerv = new();
	//               werkerv.Werkgever = ite.Element("werkgever").Value;
	//               werkerv.Functie = ite.Element("functie").Value;
	//               werkerv.Periode = ite.Element("periode").Value;
	//               werkerv.Referenties = ite.Element("referenties").Value;
	//               _curriculum.ListWorkExperience.Add(werkerv);
	//           }

	//           foreach (var ite in Record.Element("card_education").Elements())
	//           {
	//               Education opl = new Education();
	//               opl.NaamEducation = ite.Element("naameducation").Value;
	//               opl.Niveau = ite.Element("niveau").Value;
	//               opl.Diploma = ite.Element("diploma").Value;
	//               opl.Toelichting = ite.Element("toelichting").Value;
	//               _curriculum.ListEducation.Add(opl);
	//           }

	//           foreach (var ite in Record.Element("card_vaardigheden").Elements())
	//           {
	//               Skill skill = new();
	//               skill.Omschrijving = ite.Element("omschrijving").Value;
	//               skill.Toelichting = ite.Element("toelichting").Value;
	//               _curriculum.ListSkills.Add(skill);
	//           }

	//           foreach (var ite in Record.Element("card_vrijetijdsbesteding").Elements())
	//           {
	//               Vrijetijdsbesteding vrijetijd = new Vrijetijdsbesteding();
	//               vrijetijd.Activiteit = ite.Element("activiteit").Value;
	//               _curriculum.ListVrijetijdsbesteding.Add(vrijetijd);
	//           }

	//           foreach (var ite in Record.Element("card_referentie").Elements())
	//           {
	//               Referentie referentie = new Referentie();
	//               referentie.Naam = ite.Element("naam").Value;
	//			referentie.Functie = ite.Element("functie").Value;
	//               _curriculum.ListReferentie.Add(referentie);
	//           }

	//           foreach (var ite in Record.Element("card_tool").Elements())
	//           {
	//               Tool tool = new Tool();
	//               tool.ExperienceLevel = ite.Element("experiencelevel").Value;
	//               _curriculum.ListTools.Add(tool);
	//           }

	//           foreach (var ite in Record.Element("card_training").Elements())
	//           {
	//               Training training = new Training();
	//               training.Naam = ite.Element("naam").Value;
	//               training.Toelichting = ite.Element("toelichting").Value;
	//               _curriculum.ListTraining.Add(training);
	//           }

	//           foreach (var ite in Record.Element("card_cursus").Elements())
	//           {
	//               Cursus cursus = new Cursus();
	//               cursus.Naam = ite.Element("naam").Value;
	//               cursus.Toelichting = ite.Element("toelichting").Value;
	//               _curriculum.ListCursus.Add(cursus);
	//           }

	//           foreach (var ite in Record.Element("card_certificaat").Elements())
	//           {
	//               Certificate certificaat = new();
	//               certificaat.Naam = ite.Element("naam").Value;
	//               certificaat.Toelichting = ite.Element("toelichting").Value;
	//               _curriculum.ListCertificates.Add(certificaat);
	//           }
	//           return _curriculum;
	//       }

	//       public void Save(Curriculum C)
	//       {
	//           //Curriculum C = ListOFCV.FirstOrDefault(c => c.Access == Accesscode);

	//           IEnumerable<XElement> LoopW()
	//           {
	//               foreach (var item in C.ListWorkExperience)
	//               {
	//                   XElement LW = new XElement("workexperience",
	//                       new XElement("id", item.Id),
	//                       new XElement("werkgever", item.Werkgever),
	//                       new XElement("functie", item.Functie),
	//                       new XElement("periode", item.Periode),
	//                       new XElement("referenties", item.Referenties));
	//                   yield return LW;
	//               }
	//           }

	//           IEnumerable<XElement> LoopO()
	//           {
	//               foreach (var item in C.ListEducation)
	//               {
	//                   XElement LO = new XElement("education",
	//                       new XElement("id", item.Id),
	//                       new XElement("naameducation", item.NaamEducation),
	//                       new XElement("niveau", item.Niveau),
	//                       new XElement("diploma", item.Diploma),
	//                       new XElement("toelichting", item.Toelichting));
	//                   yield return LO;
	//               }
	//           }

	//           IEnumerable<XElement> LoopV()
	//           {
	//               foreach (var item in C.ListSkills)
	//               {
	//                   XElement LV = new XElement("vaardigheden",
	//                       new XElement("id", item.Id),
	//                       new XElement("omschrijving", item.Omschrijving),
	//                       new XElement("toelichting", item.Toelichting));

	//                   yield return LV;
	//               }
	//           }

	//           IEnumerable<XElement> LoopVB()
	//           {
	//               foreach (var item in C.ListVrijetijdsbesteding)
	//               {
	//                   XElement LVB = new XElement("vrijetijdsbesteding",
	//                       new XElement("id", item.Id),
	//                       new XElement("activiteit", item.Activiteit));
	//                   yield return LVB;
	//               }
	//           }

	//		IEnumerable<XElement> LoopR()
	//           {
	//               foreach (var item in C.ListReferentie)
	//               {
	//                   XElement LR = new XElement("referentie",
	//                       new XElement("id", item.Id),
	//                       new XElement("naam", item.Naam),
	//					new XElement("functie", item.Functie));
	//                   yield return LR;
	//               }
	//           }

	//		IEnumerable<XElement> LoopT()
	//           {
	//               foreach (var item in C.ListTools)
	//               {
	//                   XElement LT = new XElement("tool",
	//                       new XElement("id", item.Id),
	//					new XElement("experiencelevel", item.ExperienceLevel));
	//                   yield return LT;
	//               }
	//           }

	//		IEnumerable<XElement> LoopTraining()
	//           {
	//               foreach (var item in C.ListTraining)
	//               {
	//                   XElement LTraining = new XElement("training",
	//                       new XElement("id", item.Id),
	//					new XElement("naam", item.Naam),
	//					new XElement("toelichting", item.Toelichting)
	//					);
	//                   yield return LTraining;
	//               }
	//           }

	//		IEnumerable<XElement> LoopCursus()
	//           {
	//               foreach (var item in C.ListCursus)
	//               {
	//                   XElement LCursus = new XElement("cursus",
	//                       new XElement("id", item.Id),
	//					new XElement("naam", item.Naam),
	//					new XElement("toelichting", item.Toelichting)
	//					);
	//                   yield return LCursus;
	//               }
	//           }

	//		IEnumerable<XElement> LoopCertificaat()
	//           {
	//               foreach (var item in C.ListCertificates)
	//               {
	//                   XElement LCertificaat = new XElement("certificaat",
	//                       new XElement("id", item.Id),
	//					new XElement("naam", item.Naam),
	//					new XElement("toelichting", item.Toelichting)
	//					);
	//                   yield return LCertificaat;
	//               }
	//           }

	//           XElement changedXelement = new XElement("cv",
	//               new XElement("access", C.Access),
	//               new XElement("voornaam", C.Voornaam),
	//               new XElement("tussenvoegsel", C.Tussenvoegsel),
	//               new XElement("achternaam", C.Achternaam),
	//               new XElement("leeftijd", C.Leeftijd),
	//               new XElement("adres", C.Adres),
	//               new XElement("postcode", C.Postcode),
	//               new XElement("woonplaats", C.Woonplaats),
	//               new XElement("email", C.Email),
	//               new XElement("telefoon", C.Telefoon),
	//               new XElement("foto", C.Foto),
	//               new XElement("meta", C.Meta),
	//               new XElement("card_workexperience",
	//                   LoopW()),
	//               new XElement("card_education",
	//                   LoopO()),
	//               new XElement("card_vaardigheden",
	//                   LoopV()),
	//               new XElement("card_vrijetijdsbesteding",
	//                   LoopVB()),
	//			new XElement("card_referentie",
	//                   LoopR()),
	//			new XElement("card_tool",
	//                   LoopT()),
	//			new XElement("card_cursus",
	//                   LoopCursus()),
	//			new XElement("card_certificaat",
	//                   LoopCertificaat()),
	//			new XElement("card_training",
	//                   LoopTraining())
	//			);

	//		AllXMLContent.Add(changedXelement);
	//		Records[randIndex] = changedXelement;

	//           Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
	//           String path = Directory.GetCurrentDirectory();
	//           AllXMLContent.Save(path + "\\Xml" + "\\XMLFile.xml");
	//		AllXMLContent.Save(@"C:\Users\Admin\source\repos\CurriculumTest\CurriculumTest\Xml\XMLFile.xml");
	//       }
	//   }
}






