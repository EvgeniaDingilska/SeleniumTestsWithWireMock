const puppeteer = require('puppeteer');

(async () => {
  const browser = await puppeteer.launch();
  const page = await browser.newPage();

  // Replace 'https://example.com' with your desired URL
  await page.goto('https://example.com');

  // Optional: Add more interactions or actions here

  // Close the browser
  await browser.close();
})();
