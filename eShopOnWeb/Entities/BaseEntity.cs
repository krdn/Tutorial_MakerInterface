namespace ApplicationCore.Entities;

// 이는 다양한 키 유형을 지원하기 위해 Base Entity<T> 및 공개 T Id로 쉽게 수정될 수 있습니다.
// 단순성과 캐싱 논리를 용이하게 하기 위해 제네릭이 아닌 정수 유형 사용
public abstract class BaseEntity
{
    public virtual int Id { get; protected set; }
}
