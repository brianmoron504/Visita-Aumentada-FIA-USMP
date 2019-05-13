using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using Newtonsoft.Json; 

public class Taller : MonoBehaviour {
    public GameObject angel;
    public List<Location> location = new List<Location>();
    // Use this for initialization
    void Start () {
        //ConsumirServicio();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //void ConsumirServicio()
    //{
    //    string URL = "https://tempapi-fiara.azurewebsites.net/api/location/";
    //    var json = new WebClient().DownloadString(URL);
    //    dynamic m = JsonConvert.DeserializeObject(json);
    //    foreach (var i in m)
    //    {
    //        if (i.id == 1)
    //        {
    //           DetectLocation dLatitude = i.minLat;
    //            DetectLocation dLongitud = i.minLong;
    //        }
    //        //location.Add(new Location() { id = i.id, minlat = i.minlat, minlog = i.minlog, name = i.name, maxlat = i.maxlat, maxlong = i.maxlong });
    //    }

    //}
}
