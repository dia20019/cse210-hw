using System;
class Program
{
    static void Main(string[] args)
    {
        Address addy = new Address("204 Xitle St", "Tlalnepantla", "Mexico State", "Mexico");
        
        LectureEvent lectureEvent = new LectureEvent("Brother Robertson",30,"Presentation","Senior Project", "July 19","9:00 PM",addy);
        System.Console.WriteLine("Lecture Event");
        System.Console.WriteLine("Full Message");
        lectureEvent.FullMessage();
        System.Console.WriteLine("Standard Message");
        lectureEvent.StandardMessage();
        System.Console.WriteLine("Short Message");
        lectureEvent.ShortMessage();
        
        ReceptionEvent receptionEvent = new ReceptionEvent("RSVP@email.com","Wedding Reception","Wronsky's wedding","November 20","1:00 PM",addy);
        System.Console.WriteLine();
        System.Console.WriteLine("Reception Event");
        System.Console.WriteLine("Full Message");
        receptionEvent.FullMessage();
        System.Console.WriteLine("Standard Message");
        receptionEvent.StandardMessage();
        System.Console.WriteLine("Short Message");
        receptionEvent.ShortMessage();
        
        OutdoorEvent outdoorEvent = new OutdoorEvent("Rainy","Soccer game","America vs Atlante","July 29","3:00 PM", addy);
        System.Console.WriteLine();
        System.Console.WriteLine("Outdoor Event");
        System.Console.WriteLine("Full Message");
        outdoorEvent.FullMessage();
        System.Console.WriteLine("Standard Message");
        outdoorEvent.StandardMessage();
        System.Console.WriteLine("Short Message");
        outdoorEvent.ShortMessage();
    }
}