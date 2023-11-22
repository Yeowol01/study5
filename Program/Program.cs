using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Program
{
    internal class Program
    {
        class BinarySearch
        {
            // 이진 탐색 메소드
            static int BinarySearchFunc(int[] arr, int target)
            {
                int left = 0;
                int right = arr.Length - 1;

                while (left <= right)
                {
                    int pivot = left + (right - left) / 2;

                    // 찾고자 하는 값이 pivot과 같으면 인덱스 반환
                    if (arr[pivot] == target)
                        return pivot;

                    // 찾고자 하는 값이 pivot보다 작으면 왼쪽 부분 탐색
                    if (arr[pivot] > target)
                        right = pivot - 1;
                    else // 찾고자 하는 값이 pivot보다 크면 오른쪽 부분 탐색
                        left = pivot + 1;
                }

                // 찾고자 하는 값이 배열에 없으면 -1 반환
                return -1;
            }

            static void Main(string[] args)
            {
                #region 이진 탐색
                // 오름차순으로 정렬된 리스트에서 특정한 값의 위치를 찾는 알고리즘입니다.

                // 1. 배열의 가운데 요소의 인덱스를 pivot으로 설정합니다.

                // 2. [pivot]의 값이 찾고자 하는 요소가 같다면 검색완료

                // 3. [pivot의 값이 찾는 값보다 크다면 left ~ pivot 사이를 검색합니다.]

                // 4. [pivot의 값이 찾는 값보다 작다면 pivot ~ right 사이를 검색합니다.]

                int[] array = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
                int targetValue = 12;

                int result = BinarySearchFunc(array, targetValue);

                if (result != -1)
                    Console.WriteLine($"요소 {targetValue}의 인덱스는 {result}입니다.");
                else
                    Console.WriteLine($"배열에서 요소 {targetValue}을(를) 찾을 수 없습니다.");
                #endregion
            }
        }
    }
}
