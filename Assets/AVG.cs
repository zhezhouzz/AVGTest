using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Devart.Data.SQLite;

public class AVG : MonoBehaviour {

    const string db_prefix = "data source= ";
    const string db_name ="AVG.db";
	// Use this for initialization
	void Start () {
        GameObject.DontDestroyOnLoad(gameObject);
        string db_path = db_prefix + Application.streamingAssetsPath + "/" + db_name;
        Debug.Log(db_path);
        SQLiteHelper sql_hp = new SQLiteHelper(db_path);
        SQLiteDataReader sql_reader = sql_hp.ExecuteQuery("SELECT * FROM Lines;");
        while (sql_reader.Read()) {
            string id = sql_reader["id"].ToString();
            Debug.Log(id);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
