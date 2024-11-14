namespace project_1
{
    public class DataContext
    {

        public List<ClientcsClass> patient { get; set; }
        public List<DoctorClass> doctor { get; set; }
        public List<TurnClass> turn { get; set; }

        public DataContext() {
            List_patient = new List<ClientcsClass> {
            new ClientcsClass { Id = 1, Name = "david",Pone=0556761152,Email = "hi@email.com",Address="rabi akiva",City="bny brk"} ,
            new ClientcsClass { Id = 2, Name = "david",Pone=0556761152,Email = "hi@email.com",Address="rabi akiva",City="bny brk"} ,
            new ClientcsClass { Id = 3, Name = "david",Pone=0556761152,Email = "hi@email.com",Address="rabi akiva",City="bny brk" } };

            List_doctor = new List<DoctorClass> {
            new DoctorClass { Id = 1, Name = "david",Pone=0556761152,Email = "hi@email.com",Businesshours=7 } ,
            new DoctorClass { Id = 2, Name = "david",Pone=0556761152,Email = "hi@email.com",Businesshours=7 } ,
            new DoctorClass { Id = 3, Name = "david",Pone=0556761152,Email = "hi@email.com",Businesshours=7 } };
            List_turn = new List<TurnClass> {
        new TurnClass
         {
        Id = 1,
        NameDoctor = "SARA",
        IdDoctor = 88,
        NameClient = "DDD",
        IdClient = 99,
        Description = "88",
        Date = DateTime.Parse("2024-11-05T20:19:30.157Z"),
        Starttime = DateTime.Parse("2024-11-05T20:19:30.157Z"),
        Endtime = DateTime.Parse("2024-11-05T20:19:30.157Z")} };
            }

    }
 }
   
