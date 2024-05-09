using System.Windows.Media.Imaging;

namespace MvvmSample.Model;

public class CustomerModel
{
    #region Private Properties

    private int _id;
    private string _fname;
    private string _lname;
    private BitmapImage _image;

    #endregion

    #region Constructor

    public CustomerModel(int id, string fname , string lname, BitmapImage image)
    {
        _id = id;
        _fname = fname;
        _lname = lname;
        _image = image;
    }

    #endregion

    #region Public Properties

    public int Id 
    {
        get { return _id; }
        set { _id = value; }
    }

    public string FName
    {
        get { return _fname; }
        set { _fname = value; }
    }
    public string LName
    {
        get { return _lname; }
        set { _lname = value; }
    }
    public BitmapImage Image
    {
        get { return _image; }
        set { _image= value; }
    }

    #endregion
}
