using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct GroupMember
{
    public string memberName;
    public int birthYear;
    public string favColour;

    public GroupMember(string name, int year, string colour)
    {
        memberName = name;
        birthYear = year;
        favColour = colour;
    }

}

public class Group
{
    public List<GroupMember> members;
}