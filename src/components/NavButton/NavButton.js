import React from 'react'
import { Link } from 'react-router-dom'
import styles from './NavButton.module.css'

export default function NavButton({ item, type, url, Icon }) {

	switch (type) {
		case 'orange':
			return (
				<Link className={`${styles.orange} ${styles.btn}`} to={url}>
					<Icon /> {item}
				</Link>
			)
			break

		case 'limeGreen':
			return (
				<Link className={`${styles.limeGreen} ${styles.btn}`} to={url}>
					<Icon /> {item}
				</Link>
			)
			break

		case 'blue':
			return (
				<Link className={`${styles.blue} ${styles.btn}`} to={url}>
					<Icon /> {item}
				</Link>
			)
			break

		case 'red':
			return (
				<Link className={`${styles.red} ${styles.btn}`} to={url}>
					<Icon /> {item}
				</Link>
			)
			break

		case 'green':
			return (
				<Link className={`${styles.green} ${styles.btn}`} to={url}>
					<Icon /> {item}
				</Link>
			)
			break

		case 'navy':
			return (
				<Link className={`${styles.navy} ${styles.btn}`} to={url}>
					<Icon /> {item}
				</Link>
			)
			break

		default:
			return (
				<button className={`${styles.orange} ${styles.btn}`}>
					<Icon /> {item}
				</button>
			)
			break
	}
}
