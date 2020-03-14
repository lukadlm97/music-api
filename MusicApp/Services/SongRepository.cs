using MusicApp.Data.Model;
using Ninject.Activation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MusicApp.Services
{
    public class SongRepository
    {
        List<Song> Songs = new List<Song>
            {
                new Song
                {
                    Id=1,
                    Title="Ti si sav moj bol",
                    Author="Milan Mladenovic",
                    Length = 280,
                    Performer = new Performer
                    {
                        Id=1,
                        IsBand = true,
                        Name = "EKV",
                        BandMembers = new List<Member>
                        {
                            new Member
                            {
                                Id = 1,
                                Name = "Milan Mladenovic",
                                Age = 32,
                                Alive = false,
                                Surname = "Decak iz vode"
                            },
                            new Member
                            {
                                Id=2,
                                Name="Margita Savic",
                                Age=25,
                                Alive = false,
                                Surname="Megi"
                            }
                        }
                    }
                },
                new Song
                {
                    Id=2,
                    Title="Ovo je zemlja za nas",
                    Author="Milan Mladenovic",
                    Length = 245,
                    Performer = new Performer
                    {
                        Id=1,
                        IsBand = true,
                        Name = "EKV",
                        BandMembers = new List<Member>
                        {
                            new Member
                            {
                                Id = 1,
                                Name = "Milan Mladenovic",
                                Age = 32,
                                Alive = false,
                                Surname = "Decak iz vode"
                            },
                            new Member
                            {
                                Id=2,
                                Name="Margita Savic",
                                Age=25,
                                Alive = false,
                                Surname="Megi"
                            }
                        }
                    }
                },
                new Song
                {
                    Id=3,
                    Title="Kad hodas",
                    Author="Bora Djordjevic",
                    Length = 250,
                    Performer = new Performer
                    {
                        Id=2,
                        IsBand = true,
                        Name = "Riblja Corba",
                        BandMembers = new List<Member>
                        {
                            new Member
                            {
                                Id = 3,
                                Name = "Bora Djordjevic",
                                Age = 30,
                                Alive = true,
                                Surname = "Bora Corba"
                            },
                            new Member
                            {
                                Id=4,
                                Name="Momcilo Bajagic",
                                Age=25,
                                Alive = true,
                                Surname="Bajaga"
                            }
                        }
                    }
                }
            };

        internal Song GetSong(int id)
        {
            foreach(Song song in Songs)
            {
                if (song.Id == id)
                    return song;
            }
            return null;
        }

        public List<Song> GetSongs()
        {
            return Songs;

        }
        public bool Save(Song song)
        {
            Songs.Add(song);


            return true;
        }
    }
}
