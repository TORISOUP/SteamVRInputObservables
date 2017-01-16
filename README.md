#SteamVRInputObservables

SteamVRInputObservablesは「[SteamVR Plugin](https://www.assetstore.unity3d.com/en/#!/content/32647)」におけるControllerのInputEventをObservableとして扱えるようにするAssetです

## 導入方法

SteamVRInputObservables.unitypackageをプロジェクトにインポートしてください。
[UniRx](https://github.com/neuecc/UniRx)が別途必要となるため、こちらもインポートしてください。

## 使い方

1. 管理用のPrefab `SteamVRInputObservables/Resouces/SteamVREventTrigger` をシーンに配置して下さい
2. `SteamVREventTrigger`のInspectorViewより、`Left Controller`と`Right Controller`を設定して下さい
![InspectorView](https://raw.githubusercontent.com/TORISOUP/SteamVRInputObservables/master/images/inscpector.png)
3. `ObservableSteamInput.XXXXX` または `this.XXXXAsObservable()` の形式でストリームを取得できるようになります
`ObservableSteamInput.XXX`の方はControllerが破棄されない限りOnCompletedは発行されません
`this.XXXXAsObservable()`の方はthisが指すコンポーネントが破棄されると自動でOnCompletedを発行します

```csharp
using SteamVRInputObservables;
using UniRx;
using UnityEngine;

namespace SteamVRInputObservablesSample
{
    public class InputTest : MonoBehaviour
    {
        void Start()
        {
            ObservableSteamInput.OnRightTouchPadTouchDown()
                .Subscribe(_ => Debug.Log("OnRightTouchPadTouchDown"))
                .AddTo(this);

            this.OnRightTouchPadTouchDownAsObservable()
                .Subscribe(_ => Debug.Log("OnRightTouchPadTouchDown"));
        }

    }
}
```

```csharp
using SteamVRInputObservables;
using UniRx;
using UnityEngine;

namespace SteamVRInputObservablesSample
{
    public class InputTest2 : MonoBehaviour
    {
        void Start()
        {
            #region Right
            #region Trigger
            this.OnRightTriggerPressDownAsObservable()
                .Subscribe(_ => Debug.Log("Right Trigger PressDown"));
            this.OnRightTriggerPressUpAsObservable()
                .Subscribe(_ => Debug.Log("Right Trigger PressUp"));
            this.RightTriggerPress()
                .Subscribe(x => Debug.Log("Right Trigger Press:" + x));

            this.OnRightTriggerTouchDownAsObservable()
                 .Subscribe(_ => Debug.Log("Right Trigger TouchDown"));
            this.OnRightTriggerTouchUpAsObservable()
                .Subscribe(_ => Debug.Log("Right Trigger TouchUp"));

            this.RightTriggerValue()
                .Subscribe(x => Debug.Log("Right Trigger Value:" + x));
            #endregion

            #region TopuchPad
            this.OnRightTouchPadPressDownAsObservable()
                .Subscribe(_ => Debug.Log("Right TouchPad PressDown"));
            this.OnRightTouchPadPressUpAsObservable()
                .Subscribe(_ => Debug.Log("Right TouchPad PressUp"));
            this.RightTouchPadPress()
                .Subscribe(x => Debug.Log("Right TouchPad Press:" + x));

            this.OnRightTouchPadTouchDownAsObservable()
                 .Subscribe(_ => Debug.Log("Right TouchPad TouchDown"));
            this.OnRightTouchPadTouchUpAsObservable()
                .Subscribe(_ => Debug.Log("Right TouchPad TouchUp"));

            this.RightTouchPosition()
                .Subscribe(x => Debug.Log("Right TouchPad Position:" + x));
            #endregion

            #region Application Menu
            this.OnRightApplicationMenuPressDownAsObservable()
                .Subscribe(_ => Debug.Log("Right Application PressDown"));
            this.OnRightApplicationMenuPressUpAsObservable()
                .Subscribe(_ => Debug.Log("Right Application PressUp"));
            this.RightApplicationMenuPress()
                .Subscribe(x => Debug.Log("RightApplicationMenu:" + x));
            #endregion

            #region Grip
            this.OnRightGripPressDownAsObservable()
                 .Subscribe(_ => Debug.Log("Right Application PressDown"));
            this.OnRightGripPressUpAsObservable()
                .Subscribe(_ => Debug.Log("Right Application PressUp"));
            this.RightGripPress()
                .Subscribe(x => Debug.Log("RightGrip:" + x));

            #endregion
            #endregion
        }
    }
}
```

## 配布ライセンス

MIT Licenseで公開します


## 使用ライセンス

SteamVRInputObservablesはUniRxをベースに作成しています
Copyright (c) 2014 Yoshifumi Kawai https://github.com/neuecc/UniRx/blob/master/LICENSE
