using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Search : MonoBehaviour {
    string url = "http://kaffe.com.pe/Search_Unity.php";
    public string[] place;
	// Use this for initialization
	
	
	
	// Update is called once per frame
    IEnumerator Start()
    {
        WWW places = new WWW(url);
        yield return places;
        string placesDataString = places.text;
        place = placesDataString.Split(';');
        print(GetvalueData(place[0], "id:"));
    }

    string GetvalueData(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if (value.Contains("|"))
        {
            value = value.Remove(value.IndexOf("|"));

        }

        return value;
    }


}
