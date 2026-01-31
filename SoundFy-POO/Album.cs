namespace SoundFy_POO;

class Album
{
    private List<Musica> MusicasSalvas = new List<Musica>();
    
    public string NomeAlbum { get; set; }
    
    //Arrow Function que soma a duração de todas as músicas que estão na lista
    public int DuracaoTotal => MusicasSalvas.Sum(m => m.Duracao);


    public void AdicionarMusica(Musica musica)
    {
        MusicasSalvas.Add(musica);

        Console.WriteLine($"A música {musica.Nome} foi adicionada ao albúm {NomeAlbum} com sucesso!");
    }

    public void ListarMusicas()
    {
        Console.WriteLine($"\nO albúm {NomeAlbum} possui as seguintes músicas\n");
        foreach (var musicas in MusicasSalvas)
        {
            Console.WriteLine($"Musica: {musicas.Nome}");
        }

        Console.WriteLine($"Para ouvir o albúm {NomeAlbum} você precisará de {DuracaoTotal} segundos");
    }
}