using System;

public class Pet
{
    // instans variabler med getters och privata setters
    public string name { get;private set; }
    public int age { get; private set; }
    public bool isFemale { get; private set; }
    // Tom konstruktor
    public Pet()
    {}
  
    public Pet(string name, int age, bool isFemale) {
        
    }
}
