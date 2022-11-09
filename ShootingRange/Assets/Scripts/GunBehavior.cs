using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehavior : MonoBehaviour
{
    public Camera camera;
    public GameObject target;
    public AudioSource source;
    public AudioClip clip;
    gameBehavior gb;
    public GameObject scoreKeeper;
    public Ray ray;
    public Vector3 point;
    public RaycastHit hit;

    void Start()
    {
        //Finds the middle point of the screen.
        point = new Vector3(camera.pixelWidth / 2, camera.pixelHeight / 2, 0);

        //Locks the cursor in the middle of the screen and makes it invisible.
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        gb = scoreKeeper.GetComponent<gameBehavior>();
    }
    void Update()
    {
        //sends a ray from the camera to our earlier defined "point".
        ray = camera.ScreenPointToRay(point);
        
        //When left click hit, call the triggerHit() function and play the audio clip in the variable "clip".
        if (Input.GetMouseButtonDown(0))
        {
            triggerHit();
            if (gb.gameStarted == true)
            {
                source.PlayOneShot(clip);
            }
        }
    }
    private IEnumerator SphereIndicator(Vector3 pos)
    {
        //Create and spawn a black sphere, resembling a bullet, and destroy it after 5 seconds.
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;
        sphere.transform.localScale = new Vector3(.1f, .1f, .1f);
        var sphereRenderer = sphere.GetComponent<Renderer>();
        sphereRenderer.material.SetColor("_Color", Color.black);
        yield return new WaitForSeconds(5);
        Destroy(sphere);
    }
    void triggerHit()
    {
        //Spawn the target on a new location within the room if hit, else, spawn a bullet wherever the player aims.
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Target" && gb.gameStarted == true)
            {
                target.transform.position = new Vector3(Random.Range(2, -8), Random.Range(3, 6), Random.Range(-12, -18));
                gb.numberOfShotsHit += 1;
                gb.shotsHitTxt.text = "Shots hit: " + gb.numberOfShotsHit;
            }
            else if (gb.gameStarted == true)
            {
                gb.numberOfShotsMissed += 1;
                gb.shotsMissedTxt.text = "Shots missed: " + gb.numberOfShotsMissed;
                StartCoroutine(SphereIndicator(hit.point));
            }
            //Update the score.
            gb.score = gb.numberOfShotsHit - gb.numberOfShotsMissed;
            gb.scoreTxt.text = "Score: " + gb.score;
        }
    }
}
