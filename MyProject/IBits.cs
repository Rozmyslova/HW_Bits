using System.Text;
using System.Threading.Tasks;

internal interface IBits
{
    public bool GetBit(int num);
    public void SetBit(bool value, int num);
}