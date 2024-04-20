document.addEventListener('DOMContentLoaded', function() {
  const calendarContainer = document.getElementById('calendar');
  const prevYearBtn = document.getElementById('prevYearBtn');
  const currentMonthBtn = document.getElementById('currentMonthBtn');
  const nextYearBtn = document.getElementById('nextYearBtn');
  const currentYearElement = document.getElementById('currentYear');
  
  // Initial calendar display
  const currentYear = new Date().getFullYear();
  showCalendar(currentYear);
  currentYearElement.textContent = currentYear.toString();

  // Event listeners for navigation buttons
  prevYearBtn.addEventListener('click', function() {
    const currentYear = parseInt(calendarContainer.dataset.year);
    showCalendar(currentYear - 1);
    currentYearElement.textContent = (currentYear - 1).toString();
  });
  
  nextYearBtn.addEventListener('click', function() {
    const currentYear = parseInt(calendarContainer.dataset.year);
    showCalendar(currentYear + 1);
    currentYearElement.textContent = (currentYear + 1).toString();
  });
  
  currentMonthBtn.addEventListener('click', function() {
    const currentYear = new Date().getFullYear();
    showCalendar(currentYear);
    currentYearElement.textContent = currentYear.toString();
  });
  
  function showCalendar(year) {
    calendarContainer.innerHTML = '';
    calendarContainer.dataset.year = year;
  
    for (let month = 0; month < 12; month++) {
      const calendarMonth = document.createElement('div');
      calendarMonth.className = 'calendar-month';
  
      const monthName = new Date(year, month).toLocaleString('default', { month: 'long' });
      const monthTitle = document.createElement('h2');
      monthTitle.textContent = monthName;
  
      calendarMonth.appendChild(monthTitle);
  
      const table = document.createElement('table');
  
      const weekdays = ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat'];
      const headerRow = document.createElement('tr');
  
      for (let i = 0; i < 7; i++) {
        const weekday = document.createElement('th');
        weekday.textContent = weekdays[i];
        headerRow.appendChild(weekday);
      }
  
      table.appendChild(headerRow);
  
      const tbody = document.createElement('tbody');
  
      const daysInMonth = new Date(year, month + 1, 0).getDate();
      const firstDayOfWeek = new Date(year, month, 1).getDay();
  
      let currentDay = 1;
  
      for (let row = 0; row < 6; row++) {
        const calendarRow = document.createElement('tr');
  
        for (let col = 0; col < 7; col++) {
          const calendarCell = document.createElement('td');
  
          if (row === 0 && col < firstDayOfWeek) {
            calendarCell.textContent = '';
          } else if (currentDay > daysInMonth) {
            break;
          } else {
            if (
              year === new Date().getFullYear() &&
              month === new Date().getMonth() &&
              currentDay === new Date().getDate()
            ) {
              calendarCell.classList.add('current-day');
            }
  
            calendarCell.textContent = currentDay;
            currentDay++;
          }
  
          calendarRow.appendChild(calendarCell);
        }
  
        tbody.appendChild(calendarRow);
      }
  
      table.appendChild(tbody);
  
      calendarMonth.appendChild(table);
      calendarContainer.appendChild(calendarMonth);
    }
  }
});