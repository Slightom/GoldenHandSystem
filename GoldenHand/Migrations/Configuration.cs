namespace GoldenHand.Migrations
{
    using GoldenHand.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GoldenHand.GoldenHandContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GoldenHand.GoldenHandContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            ClearDatabase(context);
            InsertRecords(context);
        }

        private void InsertRecords(GoldenHand.GoldenHandContext context)
        {
            var c = context;

            #region formStatus
            FormStatus fs = new FormStatus();
            fs.FormStatusId = 0;
            fs.Name = "Oczekuj¹ce";
            c.FormStatuses.AddOrUpdate(fs);

            fs = new FormStatus();
            fs.FormStatusId = 1;
            fs.Name = "Wykonane";
            c.FormStatuses.AddOrUpdate(fs);

            fs = new FormStatus();
            fs.FormStatusId = 2;
            fs.Name = "Rezygnacja";
            c.FormStatuses.AddOrUpdate(fs);
            c.SaveChanges();
            #endregion

            #region seniors
            AddSenior(c, "Kar³owicza 34", "Eugeniusz Konaszewski", "587 564 675");
            AddSenior(c, "Hallera 20/22", "Jan Kokoszko", "676543323");
            AddSenior(c, "Waszyngtona 43/98", "Nadzieja Ostatnia", "87 567 890");
            AddSenior(c, "Konopnickiej 78/4", "Luba Niemoja", "85 765 432");
            AddSenior(c, "Jarzêbinowa 14/12", "Wies³awa Szmal", "765 565 987");
            AddSenior(c, "Wiejska 6/9", "Krystyna Dzwon", "654 556 871");
            AddSenior(c, "Bia³ostoczek 13/3", "Marianna Zachlej", "767 998 098");
            AddSenior(c, "Sokólska 12/4", "Wies³awa Lama", "325667987");
            AddSenior(c, "Fabryczna 18/44", "Janina Kubica", "587 564 675");
            AddSenior(c, "Jasnego Grzyba 12/5", "Maria Ma³ysz", "587 564 675");
            AddSenior(c, "Wykwintna 18/90", "Teresa Stoch", "587 564 675");
            AddSenior(c, "Szkolna 12/6", "Genowefa Schumacher", "587 564 675");
            AddSenior(c, "Koœcielna 19/1", "Krystyna Aniston", "587 564 675");
            AddSenior(c, "Wojciecha 76/4", "Julia Roberts", "587 564 675");
            AddSenior(c, "Konwaliowa 12/3", "Marta Kotlet", "587 564 675");
            AddSenior(c, "Porzeczkowa 13/9", "Janina ŒledŸ", "587 564 675");
            AddSenior(c, "Szkolna 5/7", "Marianna Wódka", "587 564 675");
            AddSenior(c, "Cicha 1/4", "Janina Kac", "587 564 675");
            AddSenior(c, "Ukoœna 16/3", "Walentyna W¹¿", "587 564 675");
            AddSenior(c, "Marmurowa 33", "Martyna Wieloryb", "587 564 675");
            AddSenior(c, "Wiejska 7/9", "Teresa B¹czek", "587 564 675");
            AddSenior(c, "Konwaliowa 44/3", "Wiktoria Smalec", "587 564 675");
            AddSenior(c, "Wielka 3", "Aleksandra Morska", "587 564 675");
            AddSenior(c, "Ma³a 1", "Wies³aw Maruda", "587 564 675");
            AddSenior(c, "Skoœna 13/3", "Ignacy Pacyfik", "587 564 675");
            AddSenior(c, "Urlopowa 12", "Krystyna Czepialska", "587 564 675");
            AddSenior(c, "Pla¿owa 22/23", "Teresa Byk", "587 564 675");
            AddSenior(c, "Mieszka 23", "Marta Wirus", "587 564 675");
            AddSenior(c, "Chrobrego 1/4", "Janusz Tracz", "587 564 675");
            AddSenior(c, "Chrobrego 8/7", "Tadeusz Rydzyk", "587 564 675");
            AddSenior(c, "Ranna 5/9", "Wiktoria ¯y³a", "587 564 675");
            AddSenior(c, "Upalna 89/3", "Luba Wilk", "587 564 675");
            AddSenior(c, "Pogodna 4/76", "Maja Kawa", "587 564 675");
            AddSenior(c, "Skrajna 13/17", "Wies³awa Tusk", "587 564 675");
            AddSenior(c, "Szkolna 3/34", "Witold Szczur", "587 564 675");
            AddSenior(c, "Wiejska 12/3", "Eugenia Pomidor", "587 564 675");
            AddSenior(c, "Warszawska 22/44", "Genowefa Szpak", "587 564 675");
            AddSenior(c, "Warszawska 12/8", "Teresa Klawisz", "587 564 675");
            AddSenior(c, "Pi³sudskiego 4/6", "Wies³awa Lotna", "587 564 675");
            AddSenior(c, "Sienkiewicza 88/44", "Marianna Pudzianowska", "587 564 675");
            AddSenior(c, "Sienkiewicza 78/4", "Wies³awa Koks", "587 564 675");
            AddSenior(c, "Wielka 6/9", "Janina Chleb", "587 564 675");
            c.SaveChanges();
            #endregion

            #region workers
            Worker w = new Worker();
            w.WorkerId = 0;
            w.Name = "Tomek Suchwa³ko";
            c.Workers.AddOrUpdate(w);

            w = new Worker();
            w.WorkerId = 1;
            w.Name = "Pawe³ Kuæ";
            c.Workers.AddOrUpdate(w);
            c.SaveChanges();
            #endregion

            #region forms
            int TomekId = c.Workers.Where(x => x.Name.Contains("Tomek")).FirstOrDefault().WorkerId;
            int PawelId = c.Workers.Where(x => x.Name.Contains("Pawe³")).FirstOrDefault().WorkerId;
            int formWykonanoId = c.FormStatuses.Where(x => x.Name.Contains("Wyko")).FirstOrDefault().FormStatusId;
            int formZgloszonoId = c.FormStatuses.Where(x => x.Name.Contains("Oczek")).FirstOrDefault().FormStatusId;
            int formRezygnacjaId = c.FormStatuses.Where(x => x.Name.Contains("Rezygn")).FirstOrDefault().FormStatusId;

            AddForm(c, 1, "klamka", new DateTime(2020, 09, 01), new DateTime(2020, 09, 03), c.Seniors.Where(x => x.Name.Contains("Konaszewski")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 2, "zamek", new DateTime(2020, 09, 01), new DateTime(2020, 09, 03), c.Seniors.Where(x => x.Name.Contains("Kokoszko")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 3, "uszczelki", new DateTime(2020, 09, 02), new DateTime(2020, 09, 04), c.Seniors.Where(x => x.Name.Contains("Ostatnia")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 4, "sedes", new DateTime(2020, 09, 02), new DateTime(2020, 09, 04), c.Seniors.Where(x => x.Name.Contains("Niemoja")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 5, "sp³uczka", new DateTime(2020, 09, 03), new DateTime(2020, 09, 05), c.Seniors.Where(x => x.Name.Contains("Szmal")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 6, "wylewka", new DateTime(2020, 09, 03), new DateTime(2020, 09, 06), c.Seniors.Where(x => x.Name.Contains("Dzwon")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 7, "cieknie kran", new DateTime(2020, 09, 04), new DateTime(2020, 09, 06), c.Seniors.Where(x => x.Name.Contains("Zachlej")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 8, "bateria ³azienka", new DateTime(2020, 09, 04), new DateTime(2020, 09, 07), c.Seniors.Where(x => x.Name.Contains("Lama")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 9, "suszarka", new DateTime(2020, 09, 05), new DateTime(2020, 09, 07), c.Seniors.Where(x => x.Name.Contains("Kubica")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 10, "mocowanie szafki", new DateTime(2020, 09, 05), new DateTime(2020, 09, 07), c.Seniors.Where(x => x.Name.Contains("Ma³ysz")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 11, "drzwi", new DateTime(2020, 09, 06), new DateTime(2020, 09, 07), c.Seniors.Where(x => x.Name.Contains("Stoch")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 12, "zamek", new DateTime(2020, 09, 06), new DateTime(2020, 09, 07), c.Seniors.Where(x => x.Name.Contains("Schumacher")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 13, "kran cieknie", new DateTime(2020, 09, 16), new DateTime(2020, 09, 18), c.Seniors.Where(x => x.Name.Contains("Aniston")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 14, "syfon", new DateTime(2020, 09, 16), new DateTime(2020, 09, 18), c.Seniors.Where(x => x.Name.Contains("Roberts")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 15, "powieszenie lustra", new DateTime(2020, 09, 17), new DateTime(2020, 09, 18), c.Seniors.Where(x => x.Name.Contains("Kotlet")).FirstOrDefault().SeniorId, PawelId, formWykonanoId);
            AddForm(c, 16, "wbicie haczyka", new DateTime(2020, 09, 17), new DateTime(2020, 09, 18), c.Seniors.Where(x => x.Name.Contains("ŒledŸ")).FirstOrDefault().SeniorId, PawelId, formWykonanoId);
            AddForm(c, 17, "wymiana syfonu", new DateTime(2020, 09, 18), new DateTime(2020, 09, 20), c.Seniors.Where(x => x.Name.Contains("Wódka")).FirstOrDefault().SeniorId, PawelId, formWykonanoId);
            AddForm(c, 18, "bateria cieknie", new DateTime(2020, 09, 18), new DateTime(2020, 09, 20), c.Seniors.Where(x => x.Name.Contains("Kac")).FirstOrDefault().SeniorId, PawelId, formWykonanoId);
            AddForm(c, 19, "okna regulacja", new DateTime(2020, 09, 19), new DateTime(2020, 09, 20), c.Seniors.Where(x => x.Name.Contains("W¹¿")).FirstOrDefault().SeniorId, PawelId, formWykonanoId);
            AddForm(c, 20, "szafka siê nie zamyka", new DateTime(2020, 09, 19), new DateTime(2020, 09, 20), c.Seniors.Where(x => x.Name.Contains("Wieloryb")).FirstOrDefault().SeniorId, PawelId, formWykonanoId);
            AddForm(c, 21, "uszczelka drzwi", new DateTime(2020, 09, 20), new DateTime(2020, 09, 21), c.Seniors.Where(x => x.Name.Contains("B¹czek")).FirstOrDefault().SeniorId, PawelId, formWykonanoId);
            AddForm(c, 22, "suszarka ³azienkowa", new DateTime(2020, 09, 20), new DateTime(2020, 09, 29), c.Seniors.Where(x => x.Name.Contains("Smalec")).FirstOrDefault().SeniorId, PawelId, formRezygnacjaId);
            AddForm(c, 23, "baczek cieknie", new DateTime(2020, 09, 21), new DateTime(2020, 09, 23), c.Seniors.Where(x => x.Name.Contains("Morska")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 24, "kontakty naprawiæ", new DateTime(2020, 09, 21), new DateTime(2020, 09, 24), c.Seniors.Where(x => x.Name.Contains("Maruda")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 25, "¿yrandol powiesiæ", new DateTime(2020, 09, 22), new DateTime(2020, 09, 25), c.Seniors.Where(x => x.Name.Contains("Pacyfik")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 26, "zabiæ paj¹ka", new DateTime(2020, 09, 22), new DateTime(2020, 09, 23), c.Seniors.Where(x => x.Name.Contains("Czepialska")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 27, "powieszenie szafki", new DateTime(2020, 09, 23), new DateTime(2020, 09, 23), c.Seniors.Where(x => x.Name.Contains("Byk")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 28, "naprawa drzwi", new DateTime(2020, 09, 23), new DateTime(2020, 09, 25), c.Seniors.Where(x => x.Name.Contains("Wirus")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 29, "wymiana zamka", new DateTime(2020, 09, 24), new DateTime(2020, 10, 04), c.Seniors.Where(x => x.Name.Contains("Konaszewski")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 30, "naprawa zawiasów", new DateTime(2020, 09, 24), new DateTime(2020, 10, 08), c.Seniors.Where(x => x.Name.Contains("Zachlej")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 31, "sedes", new DateTime(2020, 09, 25), new DateTime(2020, 10, 20), c.Seniors.Where(x => x.Name.Contains("Roberts")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 32, "silikon wanna", new DateTime(2020, 09, 25), new DateTime(2020, 10, 21), c.Seniors.Where(x => x.Name.Contains("Wódka")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 33, "roleta", new DateTime(2020, 09, 27), new DateTime(2020, 09, 29), c.Seniors.Where(x => x.Name.Contains("Tracz")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 34, "okna regulacja", new DateTime(2020, 09, 27), new DateTime(2020, 09, 29), c.Seniors.Where(x => x.Name.Contains("Rydzyk")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 35, "okna", new DateTime(2020, 10, 01), new DateTime(2020, 10, 02), c.Seniors.Where(x => x.Name.Contains("¯y³a")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 36, "okna", new DateTime(2020, 10, 01), new DateTime(2020, 10, 03), c.Seniors.Where(x => x.Name.Contains("Wilk")).FirstOrDefault().SeniorId, PawelId, formWykonanoId);
            AddForm(c, 37, "okna", new DateTime(2020, 10, 02), new DateTime(2020, 10, 03), c.Seniors.Where(x => x.Name.Contains("Kawa")).FirstOrDefault().SeniorId, PawelId, formWykonanoId);
            AddForm(c, 38, "okna", new DateTime(2020, 10, 02), new DateTime(2020, 10, 05), c.Seniors.Where(x => x.Name.Contains("Tusk")).FirstOrDefault().SeniorId, PawelId, formWykonanoId);
            AddForm(c, 39, "okna", new DateTime(2020, 10, 03), new DateTime(2020, 10, 05), c.Seniors.Where(x => x.Name.Contains("Szczur")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 40, "okna", new DateTime(2020, 10, 03), new DateTime(2020, 10, 07), c.Seniors.Where(x => x.Name.Contains("Pomidor")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 41, "okna", new DateTime(2020, 10, 04), new DateTime(2020, 10, 07), c.Seniors.Where(x => x.Name.Contains("Szpak")).FirstOrDefault().SeniorId, PawelId, formWykonanoId);
            AddForm(c, 42, "okna", new DateTime(2020, 10, 04), new DateTime(2020, 10, 09), c.Seniors.Where(x => x.Name.Contains("Klawisz")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 43, "okna", new DateTime(2020, 10, 10), new DateTime(2020, 10, 11), c.Seniors.Where(x => x.Name.Contains("Lotna")).FirstOrDefault().SeniorId, PawelId, formWykonanoId);
            AddForm(c, 44, "okna", new DateTime(2020, 10, 10), new DateTime(2020, 10, 14), c.Seniors.Where(x => x.Name.Contains("Pudzianowska")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 45, "okna", new DateTime(2020, 10, 12), new DateTime(2020, 10, 15), c.Seniors.Where(x => x.Name.Contains("Koks")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 46, "okna", new DateTime(2020, 10, 12), new DateTime(2020, 10, 21), c.Seniors.Where(x => x.Name.Contains("Chleb")).FirstOrDefault().SeniorId, TomekId, formWykonanoId);
            AddForm(c, 47, "klamka", new DateTime(2020, 10, 13), new DateTime(2020, 11, 14), c.Seniors.Where(x => x.Name.Contains("Konaszewski")).FirstOrDefault().SeniorId, TomekId, formZgloszonoId);
            c.SaveChanges();
            #endregion

            #region Bills
            Bill b = new Bill();
            b.Name = "Benmar 42 pu³ku";
            b.Amount = 434.21;
            b.Date = new DateTime(2020, 09, 30);
            c.Bills.AddOrUpdate(b);

            b = new Bill();
            b.Name = "LM hetmañska Tomek";
            b.Amount = 104.12;
            b.Date = new DateTime(2020, 09, 28);
            c.Bills.AddOrUpdate(b);

            b = new Bill();
            b.Name = "VBH klamki okna Tomek";
            b.Amount = 76.00;
            b.Date = new DateTime(2020, 10, 16);
            c.Bills.AddOrUpdate(b);
            c.SaveChanges();
            #endregion
        }

        private void AddForm(GoldenHandContext context, int lp, string info, DateTime regist, DateTime repair, int seniorId, int workerId, int statusId)
        {
            Form f = new Form();
            f.Lp = lp;
            f.Info = info;
            f.RegistrationDate = regist;
            f.RepairDate = repair;
            f.SeniorId = seniorId;
            f.WorkerId = workerId;
            f.FormStatusId = statusId;
            context.Forms.AddOrUpdate(f);
        }

        private void AddSenior(GoldenHandContext context, string address, string name, string phone)
        {
            Senior s = new Senior();
            s.Address = address;
            s.Name = name;
            s.PhoneNumber = phone;
            s.SeniorShortcut = name + ", " + address;
            context.Seniors.AddOrUpdate(s);
        }

        private void ClearDatabase(GoldenHand.GoldenHandContext context)
        {
            var c = context;

            var itemsToDelete0 = c.Forms;
            c.Forms.RemoveRange(itemsToDelete0);
            c.SaveChanges();

            var itemsToDelete1 = c.Workers;
            c.Workers.RemoveRange(itemsToDelete1);

            var itemsToDelete2 = c.Seniors;
            c.Seniors.RemoveRange(itemsToDelete2);

            var itemsToDelete3 = c.FormStatuses;
            c.FormStatuses.RemoveRange(itemsToDelete3);

            var itemstoDelete4 = c.Bills;
            c.Bills.RemoveRange(itemstoDelete4);

            c.SaveChanges();
        }
    }
}
