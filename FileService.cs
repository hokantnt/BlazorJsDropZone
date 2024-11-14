using Microsoft.AspNetCore.Components.Forms;
using System.Collections.ObjectModel;


namespace FilepickerLab;

public class FileService
{
    public ObservableCollection<IBrowserFile> LoadedFiles { get; } = [];
}
