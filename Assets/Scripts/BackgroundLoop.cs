using UnityEngine;

// 왼쪽 끝으로 이동한 배경을 오른쪽 끝으로 재배치하는 스크립트
public class BackgroundLoop : MonoBehaviour {
    private float width; // 배경의 가로 길이

    private void Awake() 
    {
        // 가로 길이를 측정하는 처리, start 메서드보다 실행시점 한 프레임빠름
        BoxCollider2D backgroundCollider =GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;

    }

    private void Update() 
    {
        // 매프레임마다 현재위치(게임 오브젝트의 x축) 검사 
        // 현재 위치가 원점에서 왼쪽으로 width 이상 이동했을때 위치를 리셋(재배치)
        if (transform.position.x <= -width)
        { 
            //x값이 -widthq 보다 작거나 같다? = 왼쪽으로 많이 이동했음 
            Reposition();
        }
    }

    // 위치리셋 메서드
    private void Reposition() 
    {
        Vector2 offset =new Vector2(width *2f, 0); //현위치에서 얼마만큼 오른쪽으로 밀지
        transform.position =(Vector2) transform.position +offset;
        

        //offset은 vector2 타입인데 transform.position은 vector 3타입임 
        //(vector2) 로 형변환 
    }
}