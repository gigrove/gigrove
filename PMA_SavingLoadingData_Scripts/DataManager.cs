using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml.Serialization;
using System.Text;

public class DataManager : MonoBehaviour
{
    private string _datapath;
    private string _xmlMemberData;
    private string _jsonMemberData;

    public List<GroupMember> GroupData = new List<GroupMember>
    {
        new GroupMember("Jellyfish", 19403, "none, since blind"),
        new GroupMember("Dry leaf on wind", 2024, "green, said with a sense of bittersweet longing"),
        new GroupMember("Lil' guy", 2024, "green :)")
    };

    private void Awake()
    {
        _datapath = Application.persistentDataPath + "/Group_Data/";
        _xmlMemberData = _datapath + "MembersXML.xml";
        _jsonMemberData = _datapath + "MembersJSON.json";
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_datapath);
        NewDirectory();
        SerialiseXML();
        DeserializeXML();
        SerialiseJSON();
        DeserialiseJSON();
    }

    public void NewDirectory()
    {
        if (File.Exists(_datapath))
        {
            Debug.Log("Directory exists...");
            return;
        }
        Directory.CreateDirectory(_datapath);
        Debug.Log("New Directory created!");
    }

    public void SerialiseXML()
    {
        var xmlSerializer = new XmlSerializer(typeof(List<GroupMember>));

        using(FileStream stream = File.Create(_xmlMemberData))
        {
            xmlSerializer.Serialize(stream, GroupData);
        }
    }

    
    public void DeserializeXML()
    {
        if (File.Exists(_xmlMemberData))
        {
            var xmlSerializer = new XmlSerializer(typeof(List<GroupMember>));

            using (FileStream stream = File.OpenRead(_xmlMemberData))
            {
                var groupMembers = (List<GroupMember>)xmlSerializer.Deserialize(stream);
                Debug.Log("<b>Reading from XML: </b>\n");

                foreach (var person in groupMembers)
                {
                    Debug.Log($"{person.memberName} was born in {person.birthYear} and their favourite colour is {person.favColour}.");
                }

                Debug.Log("Successfully read from XML :)");
            }
        }
        else
            Debug.Log("XML file doesn't exist...");
    }
    
    public void SerialiseJSON()
    {
        Group myGroup = new Group();
        myGroup.members = GroupData;

        string jsonString = JsonUtility.ToJson(myGroup, true);

        using(StreamWriter stream = File.CreateText(_jsonMemberData))
        {
            stream.WriteLine(jsonString);
        }
    }

    public void DeserialiseJSON()
    {
        if (!File.Exists(_jsonMemberData))
        {
            Debug.Log("JSON file doesn't exist...");
            return;
        }

        Debug.Log("<b>Reading from JSON: </b>\n");
        using(StreamReader stream = new StreamReader(_jsonMemberData))
        {
            var jsonString = stream.ReadToEnd();

            var groupData = JsonUtility.FromJson<Group>(jsonString);

            foreach(var person in groupData.members)
            {
                Debug.Log($"{person.memberName} was born in {person.birthYear} and their favourite colour is {person.favColour}.");
            }

            Debug.Log("Successfully read from JSON :)");
        }

    }
}
