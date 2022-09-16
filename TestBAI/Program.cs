public class Program{
    public static Information A(string UniversityName, string LibraryName, string Address, string Tel, string Name, string Surname, string IDcard, double FT, double Payment){
        return new Information(UniversityName, LibraryName, Address, Tel, Name, Surname, IDcard, FT, Payment);
    }


static void UniversityInformation(Information info){
    Console.WriteLine("------------------------");
    Console.WriteLine("UniversityName: {0}", info.UniversityName);
    Console.WriteLine("LibaryName: {0}", info.LibraryName);
    Console.WriteLine("Adress: {0}", info.Address);
    Console.WriteLine("Tel: {0}", info.Tel);
}

static void Universityrepresentativeinformation(Information info){
    Console.WriteLine("------------------------");
    Console.WriteLine("UniversiryName: {0}", info.UniversityName);
    Console.WriteLine("Name: {0}", info.Name);
    Console.WriteLine("Surname: {0}", info.Surname);
    Console.WriteLine("IDcard: {0}", info.IDcard);
    Console.WriteLine("------------------------");
}


static void Main(string[] args){
    Information player1 = new Information("Chulalongkorn University", "RuckDee", "Pathumwan - Bangkok", "02-215-3555", "ChaiDee", "RuckDee", "153-698-4561237",79.6,7911);
    UniversityInformation(player1);
    Universityrepresentativeinformation(player1);
    Information player2 = new Information("Mahidol University", "RuckRok", "Salaya - Nakhon Pathomk", "02-849-6211", "Nondee", "JaiDee", "742-112-5687412",70.7,7725);
    UniversityInformation(player2);
    Universityrepresentativeinformation(player2);
     Information player3 = new Information("King Mongkut's Institute of Technology Ladkrabang", "GayGe", "Lat Krabang - Bangkok", "02-329-8000", "ApaiDee", "RianDee", "541-772-3215689",249,25172);
    UniversityInformation(player3);
    Universityrepresentativeinformation(player3);
     Information player4 = new Information("Khon Kaen University", "Wattana", "Khon Kaen", "043-002539", "Tumdee", "NganDee", "777-772-4578923",30.2,4369);
    UniversityInformation(player4);
    Universityrepresentativeinformation(player4);
     Information player5 = new Information("Kmutt", "Athon", "Thung Khru - Bangkok", "02-470-8000", "Nonde", "RiebDee", "003-852-4752000",208.9,18959);
    UniversityInformation(player5);
    Universityrepresentativeinformation(player5);
}

public class Information{
    public string UniversityName;
    public string LibraryName;
    public string Address;
    public string Tel;
    public string Name;
    public string Surname;
    public string IDcard;
    public double FT;
    public double Payment;
    public Information(string UniversityName, string LibraryName, string Address, string Tel, string Name, string Surname, string IDcard, double FT, double Payment){
        this.UniversityName = UniversityName;
        this.LibraryName = LibraryName;
        this.Address = Address;
        this.Tel = Tel;
        this.Name = Name;
        this.Surname = Surname;
        this.IDcard = IDcard;
        this.FT = FT;
        this.Payment = Payment;
        }
    }
}