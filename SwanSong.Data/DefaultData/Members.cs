﻿using SwanSong.Domain;
using System;
using System.Collections.Generic;

namespace SwanSong.Data.DefaultData;

public class Members
{
    public static List<Member> GetMemberDefaultData()
    {
        return new List<Member>()
        {
            new Member { Id = 1, ArtistId = 1, StageName = "Jimmy Page", FirstName = "James", Surname = "Page", MiddleName = "Patrick", DateOfBirth = new DateTime(1944, 1, 9), BirthPlaceId = 4, IsSongWriter = true, Photo="a0033bc9-c0b8-4248-8e31-f9d3938e1e34.jpg" },
            new Member { Id = 2, ArtistId = 1, StageName = "Robert Plant", FirstName = "Robert", Surname = "Plant", MiddleName = "Anthony", DateOfBirth = new DateTime(1948, 8, 20), BirthPlaceId = 3, IsSongWriter = true, Photo = "5ebc88e6-7cbd-4c84-bc80-2c2aa832104f.jpg" },
            new Member { Id = 3, ArtistId = 1, StageName = "John Paul Jones", FirstName = "John", Surname = "Paul", MiddleName = "Jones", DateOfBirth = new DateTime(1946, 1, 3), BirthPlaceId = 7, IsSongWriter = true, Photo = "b80b7338-3caa-41ce-99f9-8b39e74ce21b.jpg" },
            new Member { Id = 4, ArtistId = 1, StageName = "John Bonham", FirstName = "John", Surname = "Henry", MiddleName = "Bonham", DateOfBirth = new DateTime(1948, 5, 31), BirthPlaceId = 8, IsSongWriter = true, Photo = "7c0fa2d4-07e4-45fd-8844-85dd78e2433a.jpg" },
            new Member { Id = 5, ArtistId = 2, StageName = "Sandy Denny", FirstName = "Alexandra", Surname = "Denny", MiddleName = "Elene MacLean", DateOfBirth = new DateTime(1947, 1, 6), DateOfDeath = new DateTime(1978, 4, 21), BirthPlaceId = 9, IsSongWriter = true, Photo = "b4961727-17ff-4594-97f1-b80d3b28ca3c.jpg" },
            new Member { Id = 6, ArtistId = 3, StageName = "Bruce Springsteen", FirstName = "Bruce", Surname = "Springsteen", DateOfBirth = new DateTime(1949, 9, 23), BirthPlaceId = 10, IsSongWriter = true, Photo="734770c0-05f1-4bd9-ae4b-748cbdc64167.jpg" },
            new Member { Id = 7, ArtistId = 4, StageName = "John Denver", FirstName = "John", Surname = "Denver", DateOfBirth = new DateTime(1943, 12, 31), DateOfDeath = new DateTime(1997, 10, 12), BirthPlaceId = 11, IsSongWriter = true, Photo="08dc96d6-bbe4-429d-90b6-094b04ae8f9d.jpg" },
            new Member { Id = 8, ArtistId = 5, StageName = "Elton John", FirstName = "Elton", Surname = "John", DateOfBirth = new DateTime(1947, 3, 25), BirthPlaceId = 12, IsSongWriter = true, Photo="06cb3132-accb-4b58-a532-47bb49bdc29b.jpg" },
            new Member { Id = 9, ArtistId = 6, StageName = "John Lennon", FirstName = "John", Surname = "Lennon", DateOfBirth = new DateTime(1940, 10, 9), DateOfDeath = new DateTime(1980, 12, 8), BirthPlaceId = 13, IsSongWriter = true, Photo="69e916a9-94e6-47ce-9762-1ca6650fa434.jpg" },
            new Member { Id = 10, ArtistId = 7, StageName = "Bob Dylan", FirstName = "Robert", MiddleName = "Allen", Surname = "Zimmerman", DateOfBirth = new DateTime(1941, 5, 24), BirthPlaceId = 15, IsSongWriter = true, Photo="bb655ce4-9a14-4805-b6d3-9f84a26a250a.jpg" },
            new Member { Id = 11, ArtistId = 8, StageName = "James Dean Bradfield", FirstName = "James", MiddleName = "Dean", Surname = "Bradfield", DateOfBirth = new DateTime(1969, 2, 21), BirthPlaceId = 6, IsSongWriter = true, Photo="3d39a220-fd12-4533-adcb-7741b0c4f8ab.jpg" },
            new Member { Id = 12, ArtistId = 8, StageName = "Nicky Wire", FirstName = "Nicholas", MiddleName = "Allen", Surname = "Jones", DateOfBirth = new DateTime(1969, 2, 20), BirthPlaceId = 6, IsSongWriter = true, Photo="450e17c5-c352-452f-a1d8-4b6c4154cf9d.jpg" },
            new Member { Id = 13, ArtistId = 8, StageName = "Sean Moore", FirstName = "Sean", MiddleName = "Anthony", Surname = "Moore", DateOfBirth = new DateTime(1968, 7, 30), BirthPlaceId = 6, IsSongWriter = true, Photo="18bc8103-9380-4bde-ae46-01b8160887a3.jpg" },
            new Member { Id = 14, ArtistId = 9, StageName = "Ozzy Osbourne", FirstName = "John", MiddleName = "Michael", Surname = "Osbourne", DateOfBirth = new DateTime(1948, 12, 3), BirthPlaceId = 16, IsSongWriter = true, Photo="9366d83c-e30d-47ab-924e-f61a42d17efe.jpg" },
            new Member { Id = 15, ArtistId = 10, StageName = "Hugh Cornwell", FirstName = "Hugh", MiddleName = "Alan", Surname = "Cornwell", DateOfBirth = new DateTime(1949, 8, 28), BirthPlaceId = 17, IsSongWriter = true, Photo="e962871a-23ec-4049-a772-d5ef262c9adb.jpg" },
            new Member { Id = 16, ArtistId = 10, StageName = "Jean-Jacques Burnel", FirstName = "Jean-Jacques", Surname = "Burnel", DateOfBirth = new DateTime(1952, 2, 21), BirthPlaceId = 18, IsSongWriter = true, Photo="f5fc3019-2a61-4d80-b071-351845c5992c.jpg" },
            new Member { Id = 17, ArtistId = 10, StageName = "David Greenfield", FirstName = "David", MiddleName = "Paul", Surname = "Greenfield", DateOfBirth = new DateTime(1949, 3, 29), DateOfDeath = new DateTime(2020, 5, 3), BirthPlaceId = 19, IsSongWriter = true, Photo="8f567b5f-7982-44d9-b4b5-e9337595f8e1.jpg" },
            new Member { Id = 18, ArtistId = 10, StageName = "Jet Black", FirstName = "Brian", MiddleName = "John", Surname = "Duffy", DateOfBirth = new DateTime(1938, 8, 26), BirthPlaceId = 21, IsSongWriter = true, Photo="9833b134-75c7-456a-a1d2-f5a286dc892e.jpg" },
            new Member { Id = 19, ArtistId = 11, StageName = "Jim Kerr", FirstName = "James", Surname = "Kerr", DateOfBirth = new DateTime(1959, 7, 9), BirthPlaceId = 22, IsSongWriter = true, Photo="60267eb0-f2f5-48c8-b245-83df9a7986bd.jpg" },
            new Member { Id = 20, ArtistId = 11, StageName = "Charlie Burchill", FirstName = "Charles", Surname = "Burchill", DateOfBirth = new DateTime(1959, 11, 27), BirthPlaceId = 23, IsSongWriter = true, Photo="83a85c7e-609d-420a-b380-d2ff190a452a.jpg" },
            new Member { Id = 21, ArtistId = 11, StageName = "Ged Grimes", FirstName = "Ged", Surname = "Grimes", DateOfBirth = new DateTime(1962, 3, 28), BirthPlaceId = 24, IsSongWriter = true, Photo="4b9eee24-56a3-493f-9dfa-3159a80396fd.jpg" },
            new Member { Id = 22, ArtistId = 12, StageName = "Ian Paice", FirstName = "Ian", MiddleName = "Anderson", Surname = "Paice", DateOfBirth = new DateTime(1948, 6, 29), BirthPlaceId = 25, IsSongWriter = true, Photo="5166d6e2-42a6-44f6-bbca-ffb41733ef48.jpg" },
            new Member { Id = 23, ArtistId = 12, StageName = "Roger Glover", FirstName = "Roger", MiddleName = "David", Surname = "Glover", DateOfBirth = new DateTime(1945, 11, 30), BirthPlaceId = 26, IsSongWriter = true, Photo="85717e2f-36bf-4c2b-8920-f42c90817ce8.jpg" },
            new Member { Id = 24, ArtistId = 12, StageName = "Ian Gillan", FirstName = "Ian", Surname = "Gillan", DateOfBirth = new DateTime(1945, 8, 19), BirthPlaceId = 27, IsSongWriter = true, Photo="883f0129-b075-454d-a68c-e3d7f07bbdda.jpg" },
            new Member { Id = 25, ArtistId = 13, StageName = "Lemmy", FirstName = "Ian", MiddleName = "Fraser", Surname = "Kilmister", DateOfBirth = new DateTime(1954, 12, 24), DateOfDeath = new DateTime(2015, 12, 28), BirthPlaceId = 28, IsSongWriter = true, Photo="1a7a6266-a256-4b08-87f0-640d8e3ace60.jpg" },
            new Member { Id = 26, ArtistId = 13, StageName = "Phil 'Philthy Animal' Taylor", FirstName = "Philip", MiddleName = "John", Surname = "Taylor", DateOfBirth = new DateTime(1954, 11, 21), DateOfDeath = new DateTime(2015, 11, 12), BirthPlaceId = 29, IsSongWriter = true, Photo="04f9d8e6-1b84-4a0a-800e-1716732aaf5e.jpg" },
            new Member { Id = 27, ArtistId = 13, StageName = "'Fast' Eddie Clarke", FirstName = "Edward", MiddleName = "Allan", Surname = "Clarke", DateOfBirth = new DateTime(1950, 10, 5), DateOfDeath = new DateTime(2018, 2, 10), BirthPlaceId = 30, IsSongWriter = true, Photo="1dbe7e17-567f-4f12-883d-b253ef2d25a2.jpg" },
            new Member { Id = 28, ArtistId = 14, StageName = "Angus Young", FirstName = "Angus", MiddleName = "McKinnon", Surname = "Young", DateOfBirth = new DateTime(1955, 3, 31), BirthPlaceId = 23, IsSongWriter = true, Photo="273cc6e3-995f-44ef-9665-4b06d76ce7eb.jpg" },
            new Member { Id = 29, ArtistId = 14, StageName = "Malcolm Young", FirstName = "Malcolm", MiddleName = "Mitchell", Surname = "Young", DateOfBirth = new DateTime(1953, 1, 6), DateOfDeath = new DateTime(2017, 11, 18), BirthPlaceId = 23, IsSongWriter = true, Photo="c79c5ae5-8678-488d-a9f0-6bc18e83abb3.jpg" },
            new Member { Id = 30, ArtistId = 14, StageName = "Phil Rudd", FirstName = "Phillip", MiddleName = "Hugh Norman Witschke", Surname = "Rudzevecuis", DateOfBirth = new DateTime(1954, 5, 19), BirthPlaceId = 29, IsSongWriter = true, Photo="44b350e7-ed7f-4e3c-b6e1-5b286836e383.jpg" },
            new Member { Id = 31, ArtistId = 14, StageName = "Cliff Williams", FirstName = "Clifford", Surname = "Williams", DateOfBirth = new DateTime(1949, 12, 14), BirthPlaceId = 32, IsSongWriter = true, Photo="0445ae2a-a3ef-4636-9850-2c4420d5f91e.jpg" },
            new Member { Id = 32, ArtistId = 14, StageName = "Brian Johnson", FirstName = "Brian", MiddleName = "Francis", Surname = "Johnson", DateOfBirth = new DateTime(1947, 10, 27), BirthPlaceId = 33, IsSongWriter = true, Photo="3ab89167-5769-478e-95a8-29277316e028.jpg" },
            new Member { Id = 33, ArtistId = 16, StageName = "Mick Fleetwood", FirstName = "Michael", MiddleName = "John Kells", Surname = "Fleetwood", DateOfBirth = new DateTime(1947, 6, 24), BirthPlaceId = 34, IsSongWriter = true, Photo="75ce147a-b9e9-49f4-8a71-c4f36dc9d3cd.jpg" },
            new Member { Id = 34, ArtistId = 16, StageName = "Stevie Nicks", FirstName = "Stephanie", MiddleName = "Lynn", Surname = "Nicks", DateOfBirth = new DateTime(1948, 5, 26), DateOfDeath = new DateTime(2017, 11, 18), BirthPlaceId = 35, IsSongWriter = true, Photo="88153d6b-9d63-4f87-b49b-a660683f7adf.jpg" },
            new Member { Id = 35, ArtistId = 16, StageName = "John McVie", FirstName = "John", MiddleName = "Graham", Surname = "McVie", DateOfBirth = new DateTime(1945, 11, 26), BirthPlaceId = 36, IsSongWriter = true, Photo="8c1fc01a-79e2-479c-b92d-ec6f9ba9135d.jpg" },
            new Member { Id = 36, ArtistId = 16, StageName = "Christine McVie", FirstName = "Christine", MiddleName="Anne", Surname = "Perfect", DateOfBirth = new DateTime(1943, 7, 12), BirthPlaceId = 37, IsSongWriter = true, Photo="1fa68d08-2072-47cc-ad2b-96a27af42351.jpg" },
            new Member { Id = 37, ArtistId = 16, StageName = "Lindsey Buckingham", FirstName = "Lindsey", MiddleName = "Adams", Surname = "Buckingham", DateOfBirth = new DateTime(1949, 10, 3), BirthPlaceId = 38, IsSongWriter = true, Photo="8154868a-c01d-49e4-85d1-f85c0b0c9302.jpg" },
            new Member { Id = 38, ArtistId = 17, StageName = "Kurt Cobain", FirstName = "Kurt", MiddleName = "Donald", Surname = "Cobain", DateOfBirth = new DateTime(1967, 2, 20), DateOfDeath = new DateTime(1994, 4, 5), BirthPlaceId = 39, IsSongWriter = true, Photo="10ec8163-a6de-4c64-bd80-3a949886905e.jpg" },
            new Member { Id = 39, ArtistId = 17, StageName = "Krist Novoselic", FirstName = "Krist", MiddleName="Anthony", Surname = "Novoselic", DateOfBirth = new DateTime(1965, 5, 16), BirthPlaceId = 40, IsSongWriter = true, Photo="657837dd-f7c1-4ed5-a58e-39cc0e279d83.jpg" },
            new Member { Id = 40, ArtistId = 17, StageName = "Dave Grohl", FirstName = "David", MiddleName = "Eric", Surname = "Grohl", DateOfBirth = new DateTime(1969, 1, 14), BirthPlaceId = 41, IsSongWriter = true, Photo="7dd70c41-8fcf-4cd1-a825-78fb30c7c0ca.jpg" },
            new Member { Id = 41, ArtistId = 18, StageName = "Kate Bush", FirstName = "Catherine", Surname = "Bush", DateOfBirth = new DateTime(1958, 6, 30), BirthPlaceId = 42, IsSongWriter = true, Photo="dfdae93a-d393-41e9-ba05-78970f0b1ee1.jpg" },
            new Member { Id = 42, ArtistId = 19, StageName = "Tori Amos", FirstName = "Myra", MiddleName="Ellen", Surname = "Amos", DateOfBirth = new DateTime(1963, 8, 22), BirthPlaceId = 43, IsSongWriter = true, Photo="d4f764a9-75d6-44ff-9263-94d2cd30703e.jpg" },
            new Member { Id = 43, ArtistId = 20, StageName = "Bono", FirstName = "Paul", MiddleName = "David", Surname = "Hewson", DateOfBirth = new DateTime(1960, 5, 10), BirthPlaceId = 44, IsSongWriter = true, Photo="5b1d901a-ad92-40ad-8439-af151e472b5d.jpg" },
            new Member { Id = 44, ArtistId = 20, StageName = "The Edge", FirstName = "David", MiddleName = "Howell", Surname = "Evans", DateOfBirth = new DateTime(1961, 8, 8), BirthPlaceId = 45, IsSongWriter = true, Photo="7ad787f2-d136-4d35-9fbf-be9bcddd34c3.jpg" },
            new Member { Id = 45, ArtistId = 20, StageName = "Adam Clayton", FirstName = "Adam", MiddleName = "Charles", Surname = "Clayton", DateOfBirth = new DateTime(1960, 3, 13), BirthPlaceId = 46, IsSongWriter = true, Photo="73375c6c-cd17-41c4-824c-c5f8af912a28.jpg" },
            new Member { Id = 46, ArtistId = 20, StageName = "Larry Mullen Jr.", FirstName = "Lawrence", MiddleName=" Joseph", Surname = "Mullen Jr.", DateOfBirth = new DateTime(1961, 10, 31), BirthPlaceId = 47, IsSongWriter = true, Photo="9f24c9d9-6b23-4594-bdf3-f71da4311af7.jpg" },
            new Member { Id = 47, ArtistId = 15, StageName = "Jimi Hendrix", FirstName = "James", MiddleName = "Allen", Surname = "Hendrix", DateOfBirth = new DateTime(1942, 11, 27), DateOfDeath = new DateTime(1970, 9, 18), BirthPlaceId = 14, IsSongWriter = true, Photo="9a7bff27-93b5-43cf-8fed-743074f6182b.jpg" }
        };
    }
}