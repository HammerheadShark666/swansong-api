using static SwanSong.Helper.PhotoHelper;

namespace SwanSong.Helper.Interfaces;

public interface IPhotoHelper
{
    bool NotDefaultImage(string fileName, string defaultPhotoFilename);
    EditPhoto WasPhotoEdited(string originalPhotoFileName, string newPhotoFileName, string defaultPhotoFilename);
}
