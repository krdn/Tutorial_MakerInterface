

## [Ardalis.GuardClauses](https://github.com/ardalis/GuardClauses)

지원되는 가드 조항
- Guard.Against.Null (입력이 null인 경우 발생)
- Guard.Against.NullOrEmpty (문자열, guid 또는 배열 입력이 null이거나 비어 있는 경우 발생)
- Guard.Against.NullOrWhiteSpace (문자열 입력이 null, 비어 있거나 공백인 경우 발생)
- Guard.Against.OutOfRange (정수/DateTime/enum 입력이 제공된 범위를 벗어나는 경우 발생)
- Guard.Against.EnumOutOfRange (enum 값이 제공된 Enum 범위를 벗어나는 경우 발생)
- Guard.Against.OutOfSQLDateRange (DateTime 입력이 SQL Server DateTime 값의 유효한 범위를 벗어나는 경우 발생)
- Guard.Against.Zero (숫자 입력이 0인 경우 발생)
- Guard.Against.Expression (정의한 표현식 사용)
- Guard.Against.InvalidFormat (정규식 또는 func를 사용하여 허용되는 형식 정의)
- Guard.Against.NotFound (Null과 유사하지만 ID/키 조회에 사용되며 를 발생시킵니다 NotFoundException)