using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerMovement : MonoBehaviour
{
    public GameObject im1, im2, im3, im4, im5, im6, im7, im8, im9, ph1, ph2, ph3, ph4, ph5, ph6, ph7, ph8, ph9;

    public GameObject[] AllFlower;

    Vector2 im1InitialPos, im2InitialPos, im3InitialPos, im4InitialPos, im5InitialPos, im6InitialPos, im7InitialPos, im8InitialPos, im9InitialPos;


    void Start()
    {
        im1InitialPos = im1.transform.position;
        im2InitialPos = im2.transform.position;
        im3InitialPos = im3.transform.position;
        im4InitialPos = im4.transform.position;
        im5InitialPos = im5.transform.position;
        im6InitialPos = im6.transform.position;
        im7InitialPos = im7.transform.position;
        im8InitialPos = im8.transform.position;
        im9InitialPos = im9.transform.position;
    }

    private void Update()
    {
        if (Input.touchCount > 0)

        {
            Touch touch = Input.GetTouch(0);
        }
    }



    public void DragImage1()
    {
        im1.transform.position = Input.mousePosition;
    }

    public void DragImage2()
    {
        im2.transform.position = Input.mousePosition;
    }

    public void DragImage3()
    {
        im3.transform.position = Input.mousePosition;
    }

    public void DragImage4()
    {
        im4.transform.position = Input.mousePosition;
    }

    public void DragImage5()
    {
        im5.transform.position = Input.mousePosition;
    }

    public void DragImage6()
    {
        im6.transform.position = Input.mousePosition;
    }

    public void DragImage7()
    {
        im7.transform.position = Input.mousePosition;
    }

    public void DragImage8()
    {
        im8.transform.position = Input.mousePosition;
    }

    public void DragImage9()
    {
        im9.transform.position = Input.mousePosition;
    }



    public void DropImage1()
    {
        float Distance = Vector3.Distance(im1.transform.position, ph1.transform.position);
        if (Distance < 50)
        {
            im1.transform.position = ph1.transform.position;
        }
        else
        {
            im1.transform.position = im1InitialPos;
        }
    }

    public void DropImage2()
    {
        float Distance = Vector3.Distance(im2.transform.position, ph2.transform.position);
        if (Distance < 50)
        {
            im2.transform.position = ph2.transform.position;
        }
        else
        {
            im2.transform.position = im2InitialPos;
        }
    }


    public void DropImage3()
    {
        float Distance = Vector3.Distance(im3.transform.position, ph3.transform.position);
        if (Distance < 50)
        {
            im3.transform.position = ph3.transform.position;
        }
        else
        {
            im3.transform.position = im3InitialPos;
        }
    }

    public void DropImage4()
    {
        float Distance = Vector3.Distance(im4.transform.position, ph4.transform.position);
        if (Distance < 50)
        {
            im4.transform.position = ph4.transform.position;
        }
        else
        {
            im4.transform.position = im4InitialPos;
        }
    }

    public void DropImage5()
    {
        float Distance = Vector3.Distance(im5.transform.position, ph5.transform.position);
        if (Distance < 50)
        {
            im5.transform.position = ph5.transform.position;
        }
        else
        {
            im5.transform.position = im5InitialPos;
        }
    }

    public void DropImage6()
    {
        float Distance = Vector3.Distance(im6.transform.position, ph6.transform.position);
        if (Distance < 50)
        {
            im6.transform.position = ph6.transform.position;
        }
        else
        {
            im6.transform.position = im6InitialPos;
        }
    }

    public void DropImage7()
    {
        float Distance = Vector3.Distance(im7.transform.position, ph7.transform.position);
        if (Distance < 50)
        {
            im7.transform.position = ph7.transform.position;
        }
        else
        {
            im7.transform.position = im7InitialPos;
        }
    }

    public void DropImage8()
    {
        float Distance = Vector3.Distance(im8.transform.position, ph8.transform.position);
        if (Distance < 50)
        {
            im8.transform.position = ph8.transform.position;
        }
        else
        {
            im8.transform.position = im8InitialPos;
        }
    }

    public void DropImage9()
    {
        float Distance = Vector3.Distance(im9.transform.position, ph9.transform.position);
        if (Distance < 50)
        {
            im9.transform.position = ph9.transform.position;
        }
        else
        {
            im9.transform.position = im9InitialPos;
        }
    }
}
