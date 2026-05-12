using System;

public class Marvel
{
    private readonly string _characterName;

    public Marvel(string characterName)
    {
        this._characterName = characterName;
    }

    public string CharacterName
    {
        get
        {
            return _characterName;
        }
    }

    public void PrintCharacterName()
    {
        Console.WriteLine(this.CharacterName);
    }
}