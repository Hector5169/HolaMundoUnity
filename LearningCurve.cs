using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private int CurrentAge = 30;
    public int AddedAge = 1;

    public float Pi = 3.14f;
    public string FirstName = "Harrison";
    public bool IsAutor = true;

    public string CharacterClass = "Ranger"; //Class Scope (Variable de clase) Una forma de verla seria como variable glogal

    public bool hasDungeonKey = true;

    public int CurrentGold = 32;

    public string weaponType = "EspadaLarga";
    public bool weaponEquipped = true;

    public bool PureOfHeart = true;
    public bool HasSecretIncantation = false;
    public string RareItem = "Relic Stone";

    string CharacterAction = "Heal";

    public int DiceRoll = 7;

    // Start is called before the first frame update
    void Start()
    {
        FindPartyMember();
        OpenTreasureChamber();
        Thievery();
        ComputeAge();
        PrintCharacterAction();
        RollDice();

        int MyInteger = 3;
        float MyFloat = MyInteger;
        int ExplicitConversion = (int)3.14; // Esto le dice al compilador que somos conscientes de que se pueden perder datos (o precisión).
                                            //var CurrentAge = 32; se utiliza var solo cuando no sabemos el tipo de dato que nos esta llegando, es recomendable utilizarla cuando estamos probando codigo y no sabemos el tipo de dato que se esta almacenando.
        int CharacterHealth = 100; //Local scope 1 (Variable local) se usa solo en esta parte espesifica del codigo.
        string FullName = "Harrison " + "Ferrone";
        int CharacterLevel = 32;
        int NextSkillLevel = GenerateCharacter("Spike", CharacterLevel);
        int NewCreation = NewCharacter("Frieren", CharacterLevel);
        int gold = 7;


        if (hasDungeonKey)
        {
            Debug.Log("Tu posees la llave sagrada - Entra");
        }
        else
        {
            Debug.Log("Todavia no has demostrado tu valia");
        }

        if (!hasDungeonKey)
        {
            Debug.Log("No puedes entrar sin la llave sagrada");
        }
        if (weaponType != "Espadalarga")
        {
            Debug.Log("Parece que no tienes el tipo de arma adecuado");
        }

        if (weaponEquipped)
        {
            if (weaponType == "EspadaLarga")
            {
                Debug.Log("Por la Reina!");
            }
        }

        else
        {
            Debug.Log("Los puños no van a funcionar contra la armadura...");
        }

        if (weaponEquipped && weaponType == "Espadalarga")
        {
            Debug.Log("For the Queen!");
        }

        Debug.Log(30 + 1);
        Debug.Log(CurrentAge + 1);
        Debug.Log("El TEXTO VA AQUI");
        Debug.Log(CurrentAge);
        Debug.LogFormat("El texto va aqui, agregue {0} y {1} como variable placeholders", CurrentAge, FirstName);

        Debug.Log($"Una cadena puede tener variables como {FirstName} insertadas directamente!");
        Debug.LogFormat($"Una cadena puede tener variables como {{0}} insertadas directamente!", FirstName);

        Debug.Log(MyInteger);
        Debug.Log(MyFloat);
        Debug.Log(ExplicitConversion);

        Debug.Log(CharacterClass + " - HP: " + CharacterHealth);

        Debug.Log(FullName);

        Debug.Log("Elija un Personaje");
        GenerateCharacter("Spike", CharacterLevel); // Argumentos (o tambien valores de argumentos para el parametro GenerateCharacter()) del parametro public void GenerateCharacter(string Name, int Level) lina 77
        Debug.Log("Una buena eleccion");

        Debug.Log(NextSkillLevel);
        Debug.Log(GenerateCharacter("Fayde", CharacterLevel));

        NewCharacter("Frieren", NewCreation);
        GenerateCharacter("Nuevo", NewCreation);

        /* SE MOVIO LA LISTA QuestPartyMembers a una funcion llamada FindPartyMember();
        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim el Barbaro,",
            "Merlin el Hechicero,",
            "Sterling el Caballero,",
        };
        int listLength = QuestPartyMembers.Count;

        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Indice: {0} - {1}", i, QuestPartyMembers[i]);
        }

        QuestPartyMembers.Add("Craven el Nigromante,");
        QuestPartyMembers.Insert(1, "Tanis el Labron,");
        QuestPartyMembers.RemoveAt(0);// o tambien usar QuestPartyMembers.Remove("Grim el Barbaro");
        foreach (string member in QuestPartyMembers)
        {
            Debug.Log(member);
        }

        StringBuilder membersString = new StringBuilder();
        foreach (string member in QuestPartyMembers)
        {
            membersString.Append(member + " ");
        }
        Debug.LogFormat("Miembros en el grupo: {0}", membersString.ToString());

        Debug.LogFormat("Miembros en el grupo: {0}", QuestPartyMembers.Count);
        */

        Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
        {
            { "Posion", 5 },
            { "Antidoto", 7 },
            { "Aspirina", 1 }
        };
        Debug.LogFormat("Items: {0}", ItemInventory.Count);

        foreach (KeyValuePair<string, int> kvp in ItemInventory)
        {
            Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);

            if (gold > kvp.Value)
            {
                Debug.Log("Tienes el oro!!");
            }
            else
            {
                Debug.Log("No tienes oro suficiente en estos momentos");
            }


        }

    }
    /// <summary>
    /// Creacion del personaje
    /// </summary>
    void CreateCharacter()
    {
        string CharacterName = "Aragon"; //Local Scope 2
        Debug.Log(CharacterName + " - " + CharacterClass);
    }
    /// <summary>
    /// Time for action - adding comments
    /// Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }

    public void MethodName()
    {
        Debug.Log($"Una cadena puede tener variables como {FirstName} insertar directamente!");
        //Debug.Log(FirstName * Pi); Error no se pueden multiplicar cadenas y flotantes
    }


    /// <summary>
    /// Generar Personaje
    /// </summary>
    public int GenerateCharacter(string Name, int Level) // Parametros para este metodo GenerateCharacter () los parametros que se agregaron al metodo fueron (string Name, int Level)
    {
        Debug.LogFormat("Personaje: {0} - Nivel: {1}", Name, Level);
        return Level += 5;
    }

    public int NewCharacter(string Name, int Level)
    {
        Debug.LogFormat("Nuevo Personaje: {0} + Nivel: {1}", Name, Level);
        return Level += 10;
    }

    public void Thievery()
    {
        if (CurrentGold > 50)
        {
            Debug.Log("Estas robando en el");
        }

        else if (CurrentGold < 15)
        {
            Debug.Log("No hay mucho que robar");
        }

        else
        {
            Debug.Log("Parece que tu bolso esta en el punto optimo");
        }
    }

    public void OpenTreasureChamber()
    {
        if (PureOfHeart && RareItem == "Relic Stone")
        {
            if (!HasSecretIncantation)
            {
                Debug.Log("Tienes el espiritu pero no el conocimiento");
            }
            else
            {
                Debug.Log("El tesoro es tuyo digno Heroe");
            }

        }
        else
        {
            Debug.Log("Regresa cuando tengas lo necesario");
        }
    }

    public void PrintCharacterAction()
    {
        switch (CharacterAction)
        {
            case "Heal":
                Debug.Log("Posion enviada");
                break;

            case "Attack":
                Debug.Log("A las armas!");
                break;

            default:
                Debug.Log("Escudos arriba");
                break;
        }
    }

    public void RollDice()
    {
        switch (DiceRoll)
        {
            case 7:

            case 15:
                Debug.Log("Daño mediocre, no esta mal.");
                break;

            case 20:
                Debug.Log("Daño crítico, la criatura cae!");
                break;

            default:
                Debug.Log("Fallastes por completo y caístes de cara");
                break;
        }
    }

    public void FindPartyMember()
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim el Barbaro",
            "Merlin el Hechicero",
            "Sterling el Caballero",
        };

        int listLength = QuestPartyMembers.Count;
        QuestPartyMembers.Add("Craven el Nigromante");
        QuestPartyMembers.Insert(1, "Tanis el Labron");
        QuestPartyMembers.RemoveAt(0);// o tambien usar QuestPartyMembers.Remove("Grim el Barbaro");
       
        Debug.LogFormat("Miembros en el grupo: {0}", listLength);

        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Indice: {0} - {1}", i, QuestPartyMembers[i]);


            if (QuestPartyMembers[i] == "Merlin el Hechicero")
            {
                Debug.Log("Me alegro de que estes aqui Merlin!");
            }

        }

        foreach (string partyMember in QuestPartyMembers)//o tambien usar var para detectar automaticamente el tipo de colecion   
        {                                                //foreach (var partyMember in QuestPartyMembers)
            Debug.LogFormat("{0} - Aqui!", partyMember);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
