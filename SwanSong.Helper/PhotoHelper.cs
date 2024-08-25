using SwanSong.Helper.Interfaces;

namespace SwanSong.Helper;

public class PhotoHelper : IPhotoHelper
{
    public PhotoHelper() { }

    public record EditPhoto(bool photoWasChanged, string originalPhotoName);

    public bool NotDefaultImage(string fileName, string defaultPhotoFilename)
    {
        return !(fileName == defaultPhotoFilename);
    }

    public EditPhoto WasPhotoEdited(string originalPhotoFileName, string newPhotoFileName, string defaultPhotoFilename)
    {
        return new EditPhoto(((originalPhotoFileName != null && newPhotoFileName != null && NotDefaultImage(originalPhotoFileName, defaultPhotoFilename))
                                    && (originalPhotoFileName != newPhotoFileName)), originalPhotoFileName);
    }
}