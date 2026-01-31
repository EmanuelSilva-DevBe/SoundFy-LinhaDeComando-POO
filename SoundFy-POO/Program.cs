using SoundFy_POO;

Album album1 = new Album();

album1.NomeAlbum = "Homem litúrgico";

Musica musica1 = new Musica();
musica1.Nome = "Até outra vez";
musica1.Duracao = 232;

Musica musica2 = new Musica();
musica2.Nome = "Confissões";
musica2.Duracao = 192;

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);

album1.ListarMusicas();