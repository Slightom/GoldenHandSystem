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
            fs.Name = "Zg³oszone";
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
            Senior s = new Senior();
            s.Address = "Kar³owicz 34";
            s.Name = "Eugeniusz Konaszewski";
            s.PhoneNumber = "587 564 675";
            s.SeniorId = 0;
            c.Seniors.AddOrUpdate(s);

            s = new Senior();
            s.Address = "Hallera 20/22";
            s.Name = "Jan Kokoszko";
            s.PhoneNumber = "676543323";
            s.SeniorId = 1;
            c.Seniors.AddOrUpdate(s);

            s = new Senior();
            s.Address = "Waszyngtona 43/98";
            s.Name = "Nadzieja Ostatnia";
            s.PhoneNumber = "87 567 890";
            s.SeniorId = 2;
            c.Seniors.AddOrUpdate(s);

            s = new Senior();
            s.Address = "Konopnickiej 78/4";
            s.Name = "Luba Niemoja";
            s.PhoneNumber = "85 765 432";
            s.SeniorId = 3;
            c.Seniors.AddOrUpdate(s);
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

            Form f = new Form();
            f.FormId = 0;
            f.Lp = 1;
            f.Info = "klamka";
            f.RegistrationDate = new DateTime(2020, 10, 12);
            f.RepairDate = new DateTime(2020, 10, 20);
            f.SeniorId = c.Seniors.Where(x => x.Name.Contains("Konaszewski")).FirstOrDefault().SeniorId;
            f.WorkerId = c.Workers.Where(x => x.Name.Contains("Tomek")).FirstOrDefault().WorkerId;
            f.FormStatusId = c.FormStatuses.Where(x => x.Name.Contains("Wyko")).FirstOrDefault().FormStatusId;
            c.Forms.AddOrUpdate(f);

            f = new Form();
            f.FormId = 1;
            f.Lp = 2;
            f.Info = "okno";
            f.RegistrationDate = new DateTime(2020, 10, 13);
            f.RepairDate = new DateTime(2020, 10, 20);
            f.SeniorId = c.Seniors.Where(x => x.Name.Contains("Kokoszko")).FirstOrDefault().SeniorId;
            f.WorkerId = c.Workers.Where(x => x.Name.Contains("Pawe³")).FirstOrDefault().WorkerId;
            f.FormStatusId = c.FormStatuses.Where(x => x.Name.Contains("Wyko")).FirstOrDefault().FormStatusId;
            c.Forms.AddOrUpdate(f);

            f = new Form();
            f.FormId = 2;
            f.Lp = 3;
            f.Info = "sedes";
            f.RegistrationDate = new DateTime(2020, 10, 14);
            f.RepairDate = new DateTime(2020, 10, 29);
            f.SeniorId = c.Seniors.Where(x => x.Name.Contains("Ostatnia")).FirstOrDefault().SeniorId;
            f.WorkerId = c.Workers.Where(x => x.Name.Contains("Pawe³")).FirstOrDefault().WorkerId;
            f.FormStatusId = c.FormStatuses.Where(x=>x.Name.Contains("Zg³osz")).FirstOrDefault().FormStatusId;
            c.Forms.AddOrUpdate(f);

            f = new Form();
            f.FormId = 3;
            f.Lp = 4;
            f.Info = "bateria";
            f.RegistrationDate = new DateTime(2020, 10, 15);
            f.RepairDate = new DateTime(2020, 10, 28);
            f.SeniorId = c.Seniors.Where(x => x.Name.Contains("Ostatnia")).FirstOrDefault().SeniorId;
            f.WorkerId = c.Workers.Where(x => x.Name.Contains("Tomek")).FirstOrDefault().WorkerId;
            f.FormStatusId = c.FormStatuses.Where(x => x.Name.Contains("Rezyg")).FirstOrDefault().FormStatusId;
            c.Forms.AddOrUpdate(f);

            f = new Form();
            f.FormId = 4;
            f.Lp = 5;
            f.Info = "zamek";
            f.RegistrationDate = new DateTime(2020, 10, 11);
            f.RepairDate = new DateTime(2020, 11, 27);
            f.SeniorId = c.Seniors.Where(x => x.Name.Contains("Luba")).FirstOrDefault().SeniorId;
            f.WorkerId = c.Workers.Where(x => x.Name.Contains("Tomek")).FirstOrDefault().WorkerId;
            f.FormStatusId = c.FormStatuses.Where(x => x.Name.Contains("Zg³osz")).FirstOrDefault().FormStatusId;
            c.Forms.AddOrUpdate(f);
            c.SaveChanges();
            #endregion

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

            c.SaveChanges();
        }
    }
}
