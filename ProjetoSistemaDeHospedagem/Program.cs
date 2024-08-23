using ProjetoSistemaDeHospedagem.Models;

Person p1 = new("Matheus", "Trajano");
Person p2 = new("Trajano", "Matheus");

Suite s1 = new("Presidential", 1, 400.0M);

Reservation r1 = new(12);
r1.RegisterSuite(s1);
r1.RegisterGuests([p1, p2]);

int guestsCount = r1.GetGuestCount();
decimal value = r1.CalculateDailyRate();

Console.WriteLine($"Guests Count: {guestsCount}, Value: {value}");