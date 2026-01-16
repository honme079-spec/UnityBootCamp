namespace 리스트
{
    class Program
    {
        static void Main()
        {
            // List - 필요할떄 자동으로 커지는 배열
            // 내부적으로는 배열, 클래스 내부에서 배열을 관리
            // [ 0 ][ 1 ][ 2 ][ 3 ]   // 꽉 찼음
            //   ↓
            // [ 0 ][ 1 ][ 2 ][ 3 ][ _ ][ _ ][ _ ][ _ ]   // 더 큰 배열로 교체

            List<int> numbers = new List<int>();
            //List<float> numbers = new List<float>();
            // 제네릭 문법 <int> : 여기 안에 저장할 데이터의 타입을 지정
            // 예) List<float>, List<string>, List<Player> 등
            // 인덱스를 통해 접근

            //1) 데이터 추가
            numbers.Add(10); // numbers[0] → 10
            numbers.Add(20); // numbers[1] → 20
                             // numbers[2] → 25
            numbers.Add(30); // numbers[3] → 30

            numbers.Insert(2, 25); // 1번 인덱스에 25 삽입

            // numbers.Insert(5, 25); // 리스트범위 초과시 에러

            // [0][1][2][3]  // 2번 자리에 999 삽입
            // [0][1][ ][2][3]  → 2,3,4를 한 칸씩 뒤로 이동 후 삽입

            // 삭제
            bool test = numbers.Remove(10);  // 지우는데 성공하면 참 반환
            bool test1 = numbers.Remove(444);  // 지우는데 실패하면 거짓 반환

            numbers.RemoveAt(1); // 1번 인덱스 삭제

            //numbers.RemoveAt(6); // 인덱스 초과시 에러

            // [10][20][30][40][50]
            // [10][20][40][50]

            // 삽입, 삭제 에 시간이 오래걸린다.
            // O(n) - 선형시간
            numbers.Clear();

            // 배열(Array)                리스트(List)  
            // 크기 고정                  크기 유동적
            // 접근 속도 빠름             사용 편리
            // 메모리 절약 가능           삽입 / 삭제 자유로움
            // 크기 변경 불가             중간 삽입/삭제 시 성능 저하

            // 결론: 데이터 개수가 변하지 않는다면 배열, 변한다면 리스트

            // 2) 전체 출력
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"Index {i} : {numbers[i]}");
            }

            //foreach (int val in numbers)
            //{
            //    Console.WriteLine(val);
            //}

            

        }
    }
}
