import { CommonModule } from '@angular/common';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { LocalStorageService } from '../../../core/services/concretes/local-storage.service';
import { jwtDecode } from 'jwt-decode';
import {
  JWT_EMAIL,
  JWT_ID,
} from '../../../core/constants/jwtAttributes';

@Component({
  selector: 'app-header-item-usermenu',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './header-item-usermenu.component.html',
  styleUrl: './header-item-usermenu.component.scss',
})
export class HeaderItemUsermenuComponent implements OnInit {
  tokenId!: string;
  tokenEmail!: string;
  constructor(private LocalStorageService: LocalStorageService) {}
  @Output() logout = new EventEmitter<void>();

  callLogoutHandler() {
    this.logout.emit();
  }

  ngOnInit(): void {
    this.printTokenFromLocalStorage();
  }

  printTokenFromLocalStorage() {
    const token = this.LocalStorageService.getToken();

    if (token !== null) {
      const decodedToken = jwtDecode<any>(token);
      const id = decodedToken[JWT_ID];
      this.tokenId = id;
      console.log(id)
      const email = decodedToken[JWT_EMAIL];
      this.tokenEmail = email;
    }
  }

}
