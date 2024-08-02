Console.Write("Yaşınızı Girin: ");
int yas = Convert.ToInt32(Console.ReadLine());
Console.Write("Okuyor Musunuz? (evet: e , hayır: h)");
string OkuyorMu = Console.ReadLine();

if (OkuyorMu == "h" && yas == >=18){
    Console.WriteLine("Askere Gelme Yaşınız geldi." );
}
else if (OkuyorMu == "e" && yas >=18){
    Console.WriteLine("Okul Bitince Asker. " );
}

else {
    Console.WriteLine("Askerlik Zamanın Gelmedi."); 

}