
namespace TooltipService
{
    public class P1 {
    public string S1 { get; set; }
    }
    public class VM {
        public P1  P1 {get;set;}
    }
    
    public sealed partial class MainPage 
    {
        public MainPage()
        {
            this.InitializeComponent();
            DataContext = new VM { P1 = new P1 { S1 = "Yes!" } };
        }
    }
}
