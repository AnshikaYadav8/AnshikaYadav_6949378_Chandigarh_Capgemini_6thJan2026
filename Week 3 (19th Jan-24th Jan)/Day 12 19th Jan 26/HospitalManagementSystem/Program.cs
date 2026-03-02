namespace HospitalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Patient 2.Doctor 3.Nurse");
            int input = Convert.ToInt32(Console.ReadLine());

            switch (input) {
                case 1:
                    Patient p = new Patient();
                    p.Register();
                    p.Display();
                    Console.WriteLine("Enter Doctor Details");
                    Doctor D = new Doctor();
                    D.Register();

                    Appointment a = new Appointment();
                    a.Schedule();

                    MedicalRecord m = new MedicalRecord();
                    m.AddRecord();
                    break;
                case 2:
                    Doctor d = new Doctor();
                    d.Register();
                    d.Display(); 
                    break;
                case 3:
                    Nurse n = new Nurse();
                    n.Register();
                    n.Display();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
        }
        }
    }
}
