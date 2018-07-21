namespace VRTK.Examples
{
    using UnityEngine;

    public class Whirlygig : VRTK_InteractableObject
    {

        bool alt = true;
        public ChangingSprite cs;

        float spinSpeed = 0f;
        Transform rotator;

        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
            spinSpeed = 360f;
            cs.switchSprite(alt);
            alt = !alt;
        }

        public override void StopUsing(VRTK_InteractUse usingObject)
        {
            base.StopUsing(usingObject);
            spinSpeed = 0f;
        }

        protected void Start()
        {
            rotator = transform.Find("Capsule");
        }

        protected override void Update()
        {
            base.Update();
            rotator.transform.Rotate(new Vector3(spinSpeed * Time.deltaTime, 0f, 0f));
        }
    }
}