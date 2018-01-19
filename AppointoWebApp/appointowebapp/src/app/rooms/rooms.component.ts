import { Component, OnInit } from '@angular/core';
import { RoomsService } from "./rooms.service";

@Component({
	selector: 'app-rooms',
	templateUrl: './rooms.component.html',
	styleUrls: ['./rooms.component.css']
})
export class RoomsComponent implements OnInit {

	service: RoomsService;
	rooms: Rooms;

	constructor(svc: RoomsService) {
		this.service = svc;
	}

	ngOnInit() {
		// this.getRooms();
	}

	getRooms() {
		//		var res: Promise<Rooms> = this.service.getRooms();
		var res: any = this.service.getRooms();

		res.then(
			(r: any) => {
				this.rooms = r;
				console.log(this.rooms);
				console.log(r);
			},
			(r: any) => {
				console.log(res);
			}
		)

		// this.showResults(this.rooms);
		this.fillTable(this.rooms);
	}

	showResults(result: Rooms) {
		console.log("Show Results");
		console.log(this.rooms);
		// document.getElementById('result-count').innerHTML = result.length +
		// 	(result.length === 1 ?
		// 		' result' :
		// 		' results');

		// if (result.length > 0) {
		// 	this.fillTable(result);
		// }

		document.getElementById('result-count').innerHTML = this.rooms.length +
			(this.rooms.length === 1 ?
				' result' :
				' results');

		if (this.rooms.length > 0) {
			this.fillTable(this.rooms);
		}
	}

	fillTable(results: Rooms) {
		const target = document.getElementById('result-table');
		const header = document.createElement('thead');
		const headerRow = document.createElement('tr');
		header.appendChild(headerRow);

		for (let key in results[0]) {
			const headerCell = document.createElement('th');
			headerCell.innerText = key;
			headerRow.appendChild(headerCell);
		};
		target.appendChild(header);
		const body = document.createElement('tbody');
		results.forEach((result) => {
			const row = document.createElement('tr');
			for (let key in result) {
				const cell = document.createElement('td');
				cell.innerText = result[key];
				row.appendChild(cell);
			}
			body.appendChild(row);
		});
		target.appendChild(body);
	}
}

export class Room {
	id: number;
	roomNumber: number;
}

type Rooms = Array<Room>;