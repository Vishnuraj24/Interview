export interface PaginatedResult<T> {
    items: T[]; // Array of items of type T
    totalCount: number; // Total number of items
}