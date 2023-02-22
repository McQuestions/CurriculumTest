namespace CurriculumTest
{
	public class Curriculum
	{
		public Curriculum()
		{
			ListDating = new();
			ListProfessional = new();
			ListLocation = new();
			ListCommunications = new();
			ListWorkExperience = new();
			ListEducation = new();
			ListSkills = new();
			ListVrijetijdsbesteding = new();
			ListReferentie = new();
			ListTools = new();
			ListCertificates = new();
			ListCursus = new();
			ListTraining = new();
		}

		public string Access { get; set; }
		public string Id { get; set; }
		public string Meta { get; set; }

		public List<Dating> ListDating;
		public List<Professional> ListProfessional;
		public List<Location> ListLocation;
		public List<Communications> ListCommunications;
		public List<WorkExperience> ListWorkExperience;
		public List<Education> ListEducation;
		public List<Skill> ListSkills;
		public List<Vrijetijdsbesteding> ListVrijetijdsbesteding;
		public List<Referentie> ListReferentie;
		public List<Tool> ListTools;
		public List<Certificate> ListCertificates;
		public List<Training> ListTraining;
		public List<Cursus> ListCursus;
		public List<Resume> ListResume;
	}

	public class Dating
	{
		public bool Show { get; set; } = true;
		public string Voornaam { get; set; }
		public string Tussenvoegsel { get; set; }
		public string Achternaam { get; set; }
		public string Leeftijd { get; set; }
		public string Foto { get; set; }
	}

	public class Professional
	{
		public string? Beroep { get; set; }
		public string? Thuiswerken { get; set; }
		public string? ZoekVoorAantalUren { get; set; }
		public string? BIG_Registratie { get; set; }
		public string? ZoekWerkInRegio { get; set; }
		public string? Zzp { get; set; }
		public string? ZoektOpleidingsmogelijkheden { get; set; }
		public string? ZoektGroeimogelijkheden { get; set; }
		public string? Huisvesting { get; set; }
	}

	public class Location
	{
		public bool Show { get; set; } = true;
		public string Adres { get; set; }
		public string Postcode { get; set; }
		public string Woonplaats { get; set; }
	}

	public class Communications
	{
		public bool Show { get; set; } = true;
		public string Gemeente { get; set; } = "";
		public string Email { get; set; }
		public string Telefoon { get; set; }
	}

	public class WorkExperience
	{
		public bool Show { get; set; } = true;
		public int Id { get; set; } = 0;
		public string Werkgever { get; set; }
		public string Functie { get; set; }
		public string Periode { get; set; }
		public string Referenties { get; set; }
	}

	public class Education
	{
		public bool Show { get; set; } = true;
		public int Id { get; set; } = 0;
		public string NaamEducation { get; set; }
		public string Niveau { get; set; }
		public string Diploma { get; set; }
		public string Toelichting { get; set; }

		// Titel erbij zetten
	}

	public class Skill
	{
		public bool Show { get; set; } = true;
		public int Id { get; set; } = 0;
		public string Omschrijving { get; set; }
		public string Toelichting { get; set; }
	}

	public class Vrijetijdsbesteding
	{
		public bool Show { get; set; } = true;
		public int Id { get; set; } = 0;
		public string Activiteit { get; set; }
	}

	public class Referentie
	{
		public bool Show { get; set; } = true;
		public int Id { get; set; } = 0;
		public string Naam { get; set; }
		public string Functie { get; set; }
	}

	public class Tool
	{
		public bool Show { get; set; } = true;
		public int Id { get; set; } = 0;
		public string ExperienceLevel { get; set; }
	}

	public class Certificate
	{
		public bool Show { get; set; } = true;
		public int Id { get; set; } = 0;
		public string Naam { get; set; }
		public string Toelichting { get; set; }
	}

	public class Training
	{
		public bool Show { get; set; } = true;
		public int Id { get; set; } = 0;
		public string Naam { get; set; }
		public string Toelichting { get; set; }
	}

	public class Cursus
	{
		public bool Show { get; set; } = true;
		public int Id { get; set; } = 0;
		public string Naam { get; set; }
		public string Toelichting { get; set; }
	}

	public class Resume
	{
		public string Item { get; set; }
	}
}
