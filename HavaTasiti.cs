public class HavaTasiti:Tasit{


    // base 
    public HavaTasiti(int kapasite):base(kapasite)
    {
        // bu sınıf Tasit sınıfından kalıtım almıştır. Bu sınıf içerisinde kalıtım yolu ile gelen fieldlara erişmek için 
        // base anahtar kelimesini kullanabilirsiniz!!!
        // Örnek : Base sınıftan kalıtım yolu ile gelen Kapasite isimli field'a erişelim!!

        // base keyword'ü ile , kalıtım aldığımız sınıftan katılım yoluyla gelen üyelere sınıf içerisinden direk erişim yapabilirsiniz
        // this keyword'üne benzer bir keyword'dür.
        //base.Kapasite=10;
        
        this.Kapasite=kapasite;

        // Soru : Ben çalıştırma düğmesine bastığımda, kapasite değeri  ile ilgili nasıl bir hareket olacak!!

        
    }
}