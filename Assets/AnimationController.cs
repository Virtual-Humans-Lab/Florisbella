using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;
    [SerializeField] private Transform transform;


    [SerializeField] private int disgust;
    [SerializeField, Range(100, 1000)] private int multipliyer;

    private float time = 0f;


    private void Start()
    {
        transform.localScale = new Vector3(2f, 1, 2f);


    }

    private void Awake()
    {
       
    }

    private void Update()
    {
        disgust = (int)(Mathf.Sin(time) * multipliyer);

        skinnedMeshRenderer.SetBlendShapeWeight(12, disgust);

        time += Time.deltaTime;
    }

}
