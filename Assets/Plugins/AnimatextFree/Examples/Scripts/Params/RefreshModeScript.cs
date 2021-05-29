using AnimatextFree.Effects;
using UnityEngine;

namespace AnimatextFree.Examples
{
    public class RefreshModeScript : BaseExampleScript
    {
        public GameObject textA;
        public GameObject textB;
        public GameObject textC;
        public GameObject textD;
        public GameObject textE;

        private void Start()
        {
            AnimatextFreeUGUI animatextA;
            AnimatextFreeUGUI animatextB;
            AnimatextFreeUGUI animatextC;
            AnimatextFreeUGUI animatextD;
            AnimatextFreeUGUI animatextE;

            TLBasicA05 preset = ScriptableObject.CreateInstance<TLBasicA05>();

            preset.singleTime = 2f;
            preset.loopInterval = 1f;

            GeneralParamGroup paramGroup = new GeneralParamGroup();
            paramGroup.tag = generalParamGroup.tag;

            paramGroup.refreshMode = RefreshMode.Start;
            AddAnimatextComponent(textA, new Effect(preset, paramGroup), out animatextA);
            animatextA.PlayEffect(0);
            animatextA.Refresh(false);

            paramGroup.refreshMode = RefreshMode.Play;
            AddAnimatextComponent(textB, new Effect(preset, paramGroup), out animatextB);
            animatextB.PlayEffect(0);
            animatextB.Refresh(false);

            paramGroup.refreshMode = RefreshMode.Pause;
            AddAnimatextComponent(textC, new Effect(preset, paramGroup), out animatextC);
            animatextC.PlayEffect(0);
            animatextC.Refresh(false);

            paramGroup.refreshMode = RefreshMode.Continue;
            AddAnimatextComponent(textD, new Effect(preset, paramGroup), out animatextD);
            animatextD.PlayEffect(0);
            animatextD.Refresh(false);

            paramGroup.refreshMode = RefreshMode.End;
            AddAnimatextComponent(textE, new Effect(preset, paramGroup), out animatextE);
            animatextE.PlayEffect(0);
            animatextE.Refresh(false);
        }
    }
}