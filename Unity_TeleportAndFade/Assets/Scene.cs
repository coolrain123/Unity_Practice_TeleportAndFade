using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Scene : MonoBehaviour
{

    private Image imgcross;
    // Start is called before the first frame update
    void Start()
    {
        imgcross = GameObject.Find("轉場效果").GetComponent<Image>();
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    
    public IEnumerator NextLevel()
    {
        for (int k = 0; k < 50; k++)
        {
            imgcross.color += new Color(0, 0, 0, 0.03f);
            yield return new WaitForSeconds(0.02f);
        }
        

        SceneManager.LoadScene("第二關");
        yield return new WaitForSeconds(1f);
        for (int k = 0; k < 50; k++)
        {
            imgcross.color -= new Color(49, 49, 49, 0.03f);
            yield return new WaitForSeconds(0.02f);
        }
        
    }
}
