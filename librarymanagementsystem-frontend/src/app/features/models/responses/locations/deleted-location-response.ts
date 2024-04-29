export interface DeletedLocationResponse {
	id: string;
	shelfLineNumber: string;
	shelfFloor: string;
	shelf: string;
	corridor: string;
	floor: string;
	fullLocationMap: string;
    deletedDate: Date;
}