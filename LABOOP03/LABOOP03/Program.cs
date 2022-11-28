using LABOOP03;

Student student1 = new Student();
student1.name = "Teerasri Phopat";
student1.weight = 42.5f;

Student student2 = new Student();
student2.name = "PatraTee Sripho";
student2.weight = 66.0f;

Student student3 = new Student();
student3.name = "Rateesri Phopat ";
student3.weight = 52.8f;

Student student4 = new Student();
student4.name = "Photeesri Patra ";
student4.weight = 76.9f;

Student student5 = new Student();
student5.name = "Sriphora Teerat";
student5.weight = 60.3f;



float avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5;
Console.WriteLine("Average Weight of Student is " + avgWeight);
Console.WriteLine("Highest Weight Student is " + student4.name +  student4.weight + " Kg");
Console.WriteLine("Lowest Weight Student is " + student1.name +  student1.weight + " Kg");
Console.WriteLine("Name of the writer is Teerapat Phosri id 653450289-3");

