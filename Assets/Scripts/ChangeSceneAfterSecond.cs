using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Kelas yang akan mengubah scene setelah beberapa detik
public class ChangeSceneAfterSecond : MonoBehaviour
{
    // Referensi ke objek LoadScene yang bertanggung jawab untuk pergantian scene
    public LoadScene ls;
    
    // Waktu tunggu sebelum scene berubah, dalam detik
    public float second;
    
    // Nama scene yang akan dimuat
    public string sceneName;

    // Metode yang akan dipanggil saat objek pertama kali dijalankan
    void Start()
    {
        // Menjadwalkan pemanggilan metode ChangeAfterSecond setelah sejumlah detik
        Invoke("ChangeAfterSecond", second);
    }

    // Metode untuk mengganti scene setelah waktu tunggu selesai
    public void ChangeAfterSecond()
    {
        // Memanggil fungsi ChangeScene dari objek LoadScene untuk beralih ke scene yang diinginkan
        ls.ChangeScene(sceneName);
    }
}
