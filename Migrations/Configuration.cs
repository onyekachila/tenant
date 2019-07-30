namespace AfrimartTenants.Migrations
{
    using AfrimartTenants.Models;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    internal sealed class Configuration : DbMigrationsConfiguration<AfrimartTenants.Models.MultiTenantContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AfrimartTenants.Models.MultiTenantContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

         context.Tenants.AddOrUpdate(x => x.Id,
                   new Tenant() { Name = "SVCC", DomainName = "www.siliconvalley-codecamp.com", Id = 1, Default = true },
                   new Tenant() { Name = "ANGU", DomainName = "angularu.com", Id = 3, Default = false },
                   new Tenant() { Name = "CSSC", DomainName = "codestarssummit.com", Id = 2, Default = false }
         );

            //CreateSpeakers(context);

            //CreateSessions(context);

        }

        //private void CreateSpeakers(MultiTenantContext context)
        //{
        //    var speakerJsonAll = GetEmbeddedResourceAsString("AfrimartTenants.speaker.json");

        //    JArray jsonValSpeakers = JArray.Parse(speakerJsonAll) as JArray;
        //    dynamic speakersData = jsonValSpeakers;
        //    foreach (dynamic speaker in speakersData)
        //    {
        //        context.Speakers.Add(new Speaker
        //        {
        //            PictureId = speaker.id,
        //            FirstName = speaker.firstName,
        //            LastName = speaker.lastName,
        //            AllowHtml = speaker.allowHtml,
        //            Bio = speaker.bio,
        //            WebSite = speaker.webSite,

        //        });
        //    }
        //    context.SaveChanges();


        //}

        //private void CreateSessions(MultiTenantContext context)
        //{
        //    var sessionJsonAll = GetEmbeddedResourceAsString("AfrimartTenants.session.json");
        //    var tenants = context.Tenants.ToList();
        //    JArray jsonValSessions = JArray.Parse(sessionJsonAll) as JArray;
        //    dynamic sessionsData = jsonValSessions;

        //    var sessionTenantDict = new Dictionary<int, string>();

        //    foreach (dynamic session in sessionsData)
        //    {

        //        //var tenant = context.Tenants.FirstOrDefault(a => a.Name == tenantName);

        //        sessionTenantDict.Add((int)session.id, (string)session.tenantName);

        //        var sessionForAdd = new Session
        //        {
        //            SessionId = session.id,
        //            Description = session.description,
        //            DescriptionShort = session.descriptionShort,
        //            Title = session.title
        //        };

        //        var speakerPictureIds = new List<int>();
        //        foreach (dynamic speaker in session.speakers)
        //        {
        //            dynamic pictureId = speaker.id;
        //            speakerPictureIds.Add((int)pictureId);
        //        }

        //        sessionForAdd.Speakers = new List<Speaker>();
        //        foreach (var speakerPictureId in speakerPictureIds)
        //        {
        //            var speakerForAdd = context.Speakers.FirstOrDefault(a => a.PictureId == speakerPictureId);
        //            sessionForAdd.Speakers.Add(speakerForAdd);
        //        }
        //        context.Sessions.Add(sessionForAdd);
        //    }

        //    context.SaveChanges();
        //    foreach (var session in context.Sessions)
        //    {
        //        var tenant = tenants.
        //            FirstOrDefault(a => a.Name == sessionTenantDict[session.SessionId]);
        //        session.Tenant = tenant;
        //    }
        //    context.SaveChanges();

        //}

        //private string GetEmbeddedResourceAsString(string resourceName)
        //{
        //    // var s = Assembly.GetExecutingAssembly().GetManifestResourceNames();

        //    var assembly = Assembly.GetExecutingAssembly();

        //    string result;
        //    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        //    using (StreamReader reader = new StreamReader(stream))
        //    {
        //        result = reader.ReadToEnd();
        //    }

        //    return result;
        //}

    }
}
