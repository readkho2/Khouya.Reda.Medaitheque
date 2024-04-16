namespace Mediatheque.Core
{
    public interface INotationService
    {
        int GetNoteAlbum(string nomAlbum);
        int GetNoteJeuxSociete(string nomJeuxSociete);
    }
}
