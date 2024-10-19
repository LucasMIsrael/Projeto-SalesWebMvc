using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private Contexto _context;

        public SeedingService(Contexto context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departament.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return;
            }

            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Electronics");
            Departament d3 = new Departament(3, "Fashion");
            Departament d4 = new Departament(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", DateTime.SpecifyKind(new DateTime(1998, 4, 21), DateTimeKind.Utc), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", DateTime.SpecifyKind(new DateTime(1979, 12, 31), DateTimeKind.Utc), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", DateTime.SpecifyKind(new DateTime(1988, 1, 15), DateTimeKind.Utc), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", DateTime.SpecifyKind(new DateTime(1993, 11, 30), DateTimeKind.Utc), 3000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", DateTime.SpecifyKind(new DateTime(2000, 1, 9), DateTimeKind.Utc), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "bob@gmail.com", DateTime.SpecifyKind(new DateTime(1997, 3, 4), DateTimeKind.Utc), 3000.0, d2);

            SalesRecord r1 = new SalesRecord(1, DateTime.SpecifyKind(new DateTime(2018, 09, 25), DateTimeKind.Utc), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, DateTime.SpecifyKind(new DateTime(2018, 09, 4), DateTimeKind.Utc), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, DateTime.SpecifyKind(new DateTime(2018, 09, 13), DateTimeKind.Utc), 4000.0, SaleStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(4, DateTime.SpecifyKind(new DateTime(2018, 09, 1), DateTimeKind.Utc), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, DateTime.SpecifyKind(new DateTime(2018, 09, 21), DateTimeKind.Utc), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, DateTime.SpecifyKind(new DateTime(2018, 09, 15), DateTimeKind.Utc), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, DateTime.SpecifyKind(new DateTime(2018, 09, 28), DateTimeKind.Utc), 13000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, DateTime.SpecifyKind(new DateTime(2018, 09, 11), DateTimeKind.Utc), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, DateTime.SpecifyKind(new DateTime(2018, 09, 14), DateTimeKind.Utc), 11000.0, SaleStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(10, DateTime.SpecifyKind(new DateTime(2018, 09, 7), DateTimeKind.Utc), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(11, DateTime.SpecifyKind(new DateTime(2018, 09, 13), DateTimeKind.Utc), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, DateTime.SpecifyKind(new DateTime(2018, 09, 25), DateTimeKind.Utc), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(13, DateTime.SpecifyKind(new DateTime(2018, 09, 29), DateTimeKind.Utc), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r14 = new SalesRecord(14, DateTime.SpecifyKind(new DateTime(2018, 09, 4), DateTimeKind.Utc), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, DateTime.SpecifyKind(new DateTime(2018, 09, 12), DateTimeKind.Utc), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, DateTime.SpecifyKind(new DateTime(2018, 10, 5), DateTimeKind.Utc), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, DateTime.SpecifyKind(new DateTime(2018, 10, 1), DateTimeKind.Utc), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, DateTime.SpecifyKind(new DateTime(2018, 10, 24), DateTimeKind.Utc), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, DateTime.SpecifyKind(new DateTime(2018, 10, 22), DateTimeKind.Utc), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(20, DateTime.SpecifyKind(new DateTime(2018, 10, 15), DateTimeKind.Utc), 8000.0, SaleStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(21, DateTime.SpecifyKind(new DateTime(2018, 10, 17), DateTimeKind.Utc), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, DateTime.SpecifyKind(new DateTime(2018, 10, 24), DateTimeKind.Utc), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, DateTime.SpecifyKind(new DateTime(2018, 10, 19), DateTimeKind.Utc), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r24 = new SalesRecord(24, DateTime.SpecifyKind(new DateTime(2018, 10, 12), DateTimeKind.Utc), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, DateTime.SpecifyKind(new DateTime(2018, 10, 31), DateTimeKind.Utc), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, DateTime.SpecifyKind(new DateTime(2018, 10, 6), DateTimeKind.Utc), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(27, DateTime.SpecifyKind(new DateTime(2018, 10, 13), DateTimeKind.Utc), 9000.0, SaleStatus.Pending, s1);
            SalesRecord r28 = new SalesRecord(28, DateTime.SpecifyKind(new DateTime(2018, 10, 7), DateTimeKind.Utc), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(29, DateTime.SpecifyKind(new DateTime(2018, 10, 23), DateTimeKind.Utc), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, DateTime.SpecifyKind(new DateTime(2018, 10, 12), DateTimeKind.Utc), 5000.0, SaleStatus.Billed, s2);

            _context.Departament.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
